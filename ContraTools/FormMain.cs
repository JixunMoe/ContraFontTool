using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContraTools
{
    public partial class FormMain : Form
    {
        private readonly List<char> _charUniqueTable = new List<char>();
        private readonly List<string> _charLines = new List<string>();
        private static readonly Font RenderFont;

        static FormMain()
        {
            RenderFont = new Font("NSimSun", 11);
        }

        // private static Pen _blackPen = new Pen(Color.Black);
        public FormMain()
        {
            InitializeComponent();

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var src = (Label)sender;
            e.Graphics.FillRectangle(Brushes.White, 0, 0, src.Width, src.Height);
            
            var index = listLines.SelectedIndex;
            if (index >= 0 && index < _charLines.Count)
            {
                var str = _charLines[index];
                var line1 = str.Length >= 8 ? str.Substring(0, 8) : str;
                var line2 = str.Length >  8 ? str.Substring(8) : "";

                e.Graphics.DrawString(line1, RenderFont, Brushes.Black, 0, 0);
                e.Graphics.DrawString(line2, RenderFont, Brushes.Black, 0, 16);

                canvasReorder.Invalidate();
            }
        }

        private void canvasReorder_Paint(object sender, PaintEventArgs e)
        {
            // 从 Canvas 抽取数据重新排列
            var gCanvas = canvasOrig.CreateGraphics();
            var gReorder = e.Graphics;

            var hdcOrig = gCanvas.GetHdc();
            var hdcReorder = gReorder.GetHdc();

            // Api.BitBlt(hdcOrig, )
            var targetX = 0;
            var targetY = 0;
            for (var y = 0; y < 2*16; y += 16)
            {
                for (var x = 0; x < 8*16; x += 16)
                {
                    Api.BitBlt(hdcReorder, targetX + 8 * 0, targetY, 8, 8, hdcOrig, x + 0, y + 0, SrcCopy);
                    Api.BitBlt(hdcReorder, targetX + 8 * 1, targetY, 8, 8, hdcOrig, x + 8, y + 0, SrcCopy);
                    Api.BitBlt(hdcReorder, targetX + 8 * 2, targetY, 8, 8, hdcOrig, x + 0, y + 8, SrcCopy);
                    Api.BitBlt(hdcReorder, targetX + 8 * 3, targetY, 8, 8, hdcOrig, x + 8, y + 8, SrcCopy);

                    targetX += 32;
                    if (targetX == 8*16)
                    {
                        targetX = 0;
                        targetY += 8;
                    }
                }
            }

            gCanvas.ReleaseHdc(hdcOrig);
            gReorder.ReleaseHdc(hdcReorder);

            canvas4x.Invalidate();
        }

        private string GetDialogText(bool removeWhiteSpace)
        {
            var str = txtDialog.Text;
            if (removeWhiteSpace)
            {
                return str.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            }
            return str;
        }

        private static readonly char[] CharPrefixes = { '　', '，', '。' };
        private const int SrcCopy = 0xcc0020;

        private void btnGenFont_Click(object sender, EventArgs e)
        {
            _charUniqueTable.Clear();
            _charLines.Clear();
            var dialog = GetDialogText(true);

            // 前置空格，逗号以及句号。
            foreach (var c in CharPrefixes)
            {
                if (dialog.Contains(c))
                {
                    _charUniqueTable.Add(c);
                }
            }

            // 将不存在的字符加入列表。
            foreach (var c in dialog)
            {
                if (!_charUniqueTable.Contains(c))
                {
                    _charUniqueTable.Add(c);
                }
            }

            // 分成 16 个字符一组
            var sb = new StringBuilder();
            for (var i = 0; i < _charUniqueTable.Count; i++)
            {
                if (i%16 == 0)
                {
                    if (i != 0) _charLines.Add(sb.ToString());
                    sb = new StringBuilder();
                }

                sb.Append(_charUniqueTable[i]);
            }

            if (sb.Length != 0)
                _charLines.Add(sb.ToString());

            listLines.BeginUpdate();
            listLines.Items.Clear();
            foreach (var line in _charLines)
                listLines.Items.Add(line);
            listLines.SelectedIndex = 0;
            listLines.EndUpdate();
        }

        private void listLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listLines.SelectedIndex;
            if (index != -1) {
                canvasOrig.Invalidate();
                txtLinePreview.Text = _charLines[index];
            }

        }

        private void canvas4x_Paint(object sender, PaintEventArgs e)
        {
            var canvas = chkSplit.Checked ? canvasReorder : canvasOrig;

            var gSrc = canvas.CreateGraphics();
            var gDest = e.Graphics;

            var hdcSrc = gSrc.GetHdc();
            var hdcDest = gDest.GetHdc();

            Api.StretchBlt(hdcDest, 0, 0, canvas4x.Width, canvas4x.Height,
                           hdcSrc, 0, 0, canvas.Width, canvas.Height, SrcCopy);

            gDest.ReleaseHdc(hdcDest);
            gSrc.ReleaseHdc(hdcSrc);
        }

        private void chkSplit_CheckedChanged(object sender, EventArgs e)
        {
            canvas4x.Invalidate();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            canvasOrig.Invalidate();
        }

        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            var canvas = chkSplit.Checked ? canvasReorder : canvasOrig;

            using (var image = new Bitmap(canvas.Width, canvas.Height))
            using (var gSrc = canvas.CreateGraphics())
            using (var gDest = Graphics.FromImage(image)) {
                var hdcSrc = gSrc.GetHdc();
                var hdcDest = gDest.GetHdc();

                Api.BitBlt(hdcDest, 0, 0, canvas.Width, canvas.Height, hdcSrc, 0, 0, SrcCopy);

                gDest.ReleaseHdc(hdcDest);
                gSrc.ReleaseHdc(hdcSrc);

                Clipboard.SetImage(image);
            }
        }

        private void btnGenCode_Click(object sender, EventArgs e)
        {
            short[] ppuList; 
            int[] bankList;
            try
            {
                ppuList = txtPpu.Text.Split(',').Select(ppu => Convert.ToInt16(ppu, 10)).ToArray();
                bankList = txtBank.Text.Split(',').Select(bank => Convert.ToInt32(bank, 16)).ToArray();
            }
            catch (Exception)
            {
                txtCodes.Text = @"获取 ppu/bank 数据发生错误。";
                return;
            }
            var ppuCount = ppuList.Length;
            var bankCount = bankList.Length;

            if (ppuCount != bankCount || _charLines.Count != ppuCount)
            {
                txtCodes.Text = $"数目不匹配! 字模 {_charLines.Count}," +
                                $"ppu: {ppuList.Length}," +
                                $"bank: {bankList.Length}";
                return;
            }

            var dialog = GetDialogText(false).Replace("\r", "");
            var dialogLength = dialog.Length;
            var offsetBase = bankCount*2 + 1;
            var data = new byte[dialogLength + 1 + offsetBase];

            // 中文开始标记
            data[0] = 0xFD;

            for (var i = 0; i < ppuCount; i++)
            {
                var j = i * 2;
                data[j + 1] = (byte)(0xC0 | ppuList[i]);
                data[j + 2] = (byte)(bankList[i]);
            }
            
            for (var i = 0; i < dialogLength; i++)
            {
                var c = dialog[i];
                if (c == '\n')
                {
                    data[offsetBase + i] = 0xFE;
                }
                else if (c == ' ')
                {
                    data[offsetBase + i] = 0x00;
                }
                else
                {
                    // &F: MOD 16, INDEX
                    // >> 4: DIV 16, BANK
                    // Tile = (ppu % 4) * 0x40 + charIndex * 4
                    var index = _charUniqueTable.IndexOf(dialog[i]);
                    var charIndex = index & 0x0F;
                    var ppu = ppuList[index >> 4] & 3;

                    // 0x80: 中文字符标记
                    // data[offsetBase + i] = (byte)(((ppu * 0x40 + charIndex * 4) >> 2) | 0x80);
                    data[offsetBase + i] = (byte)(((ppu << 4) + charIndex) | 0x80);
                }
            }

            // 结束标记
            data[data.Length - 1] = 0xFF;

            var text = BitConverter.ToString(data).Replace('-', ' ').Replace("FE ", "FE\r\n");

            // 中文控制符结束处换个行
            var offset = offsetBase*3;
            text = text.Substring(0, offset - 1) + "\r\n" + text.Substring(offset);

            txtCodes.Text = text;
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCodes.Text);
            MessageBox.Show(this, @"复制成功！", Text);
        }
    }
}
