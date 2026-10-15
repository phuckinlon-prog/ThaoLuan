using System;
using System.Drawing;
using System.Windows.Forms;
using baitapthaoluan.phana;
using baitapthaoluan.phanb;
using baitapthaoluan.phand;

namespace baitapthaoluan
{
    public class main : Form
    {
        private MenuStrip menuStripMain;

        private ToolStripMenuItem mnuPhanA;
        private ToolStripMenuItem mnuBaiA1;
        private ToolStripMenuItem mnuBaiA2;
        private ToolStripMenuItem mnuBaiA3;
        private ToolStripMenuItem mnuBaiA4;

        private ToolStripMenuItem mnuPhanB;
        private ToolStripMenuItem mnuBaiB1;
        private ToolStripMenuItem mnuBaiB2;
        private ToolStripMenuItem mnuBaiB3;
        private ToolStripMenuItem mnuBaiB4;
        private ToolStripMenuItem mnuBaiB5;
        private ToolStripMenuItem mnuBaiB6;
        private ToolStripMenuItem mnuBaiB7;

        private ToolStripMenuItem mnuPhanD;
        private ToolStripMenuItem mnuBaiD1;
        private ToolStripMenuItem mnuBaiD2;
        private ToolStripMenuItem mnuBaiD3;


        private StatusStrip statusStripMain;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timerClock;

        public main()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripMain = new MenuStrip();
            mnuPhanA = new ToolStripMenuItem();
            mnuBaiA1 = new ToolStripMenuItem();
            mnuBaiA2 = new ToolStripMenuItem();
            mnuBaiA3 = new ToolStripMenuItem();
            mnuBaiA4 = new ToolStripMenuItem();
            mnuPhanB = new ToolStripMenuItem();
            mnuBaiB1 = new ToolStripMenuItem();
            mnuBaiB2 = new ToolStripMenuItem();
            mnuBaiB3 = new ToolStripMenuItem();
            mnuBaiB4 = new ToolStripMenuItem();
            mnuBaiB5 = new ToolStripMenuItem();
            mnuBaiB6 = new ToolStripMenuItem();
            mnuBaiB7 = new ToolStripMenuItem();
            mnuPhanD = new ToolStripMenuItem();
            mnuBaiD1 = new ToolStripMenuItem();
            mnuBaiD2 = new ToolStripMenuItem();
            mnuBaiD3 = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            timerClock = new System.Windows.Forms.Timer(components);
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { mnuPhanA, mnuPhanB, mnuPhanD });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(783, 28);
            menuStripMain.TabIndex = 2;
            // 
            // mnuPhanA
            // 
            mnuPhanA.DropDownItems.AddRange(new ToolStripItem[] { mnuBaiA1, mnuBaiA2, mnuBaiA3, mnuBaiA4 });
            mnuPhanA.Name = "mnuPhanA";
            mnuPhanA.Size = new Size(69, 24);
            mnuPhanA.Text = "Phần A";
            // 
            // mnuBaiA1
            // 
            mnuBaiA1.Name = "mnuBaiA1";
            mnuBaiA1.Size = new Size(224, 26);
            mnuBaiA1.Text = "Bài 1";
            mnuBaiA1.Click += MnuBaiA1_Click;
            // 
            // mnuBaiA2
            // 
            mnuBaiA2.Name = "mnuBaiA2";
            mnuBaiA2.Size = new Size(224, 26);
            mnuBaiA2.Text = "Bài 2";
            mnuBaiA2.Click += MnuBaiA2_Click;
            // 
            // mnuBaiA3
            // 
            mnuBaiA3.Name = "mnuBaiA3";
            mnuBaiA3.Size = new Size(224, 26);
            mnuBaiA3.Text = "Bài 3";
            mnuBaiA3.Click += MnuBaiA3_Click;
            // 
            // mnuBaiA4
            // 
            mnuBaiA4.Name = "mnuBaiA4";
            mnuBaiA4.Size = new Size(224, 26);
            mnuBaiA4.Text = "Bài 4";
            mnuBaiA4.Click += MnuBaiA4_Click;
            // 
            // mnuPhanB
            // 
            mnuPhanB.DropDownItems.AddRange(new ToolStripItem[] { mnuBaiB1, mnuBaiB2, mnuBaiB3, mnuBaiB4, mnuBaiB5, mnuBaiB6, mnuBaiB7 });
            mnuPhanB.Name = "mnuPhanB";
            mnuPhanB.Size = new Size(68, 24);
            mnuPhanB.Text = "Phần B";
            // 
            // mnuBaiB1
            // 
            mnuBaiB1.Name = "mnuBaiB1";
            mnuBaiB1.Size = new Size(125, 26);
            mnuBaiB1.Text = "Bài 1";
            mnuBaiB1.Click += MnuBaiB1_Click;
            // 
            // mnuBaiB2
            // 
            mnuBaiB2.Name = "mnuBaiB2";
            mnuBaiB2.Size = new Size(125, 26);
            mnuBaiB2.Text = "Bài 2";
            mnuBaiB2.Click += MnuBaiB2_Click;
            // 
            // mnuBaiB3
            // 
            mnuBaiB3.Name = "mnuBaiB3";
            mnuBaiB3.Size = new Size(125, 26);
            mnuBaiB3.Text = "Bài 3";
            mnuBaiB3.Click += MnuBaiB3_Click;
            // 
            // mnuBaiB4
            // 
            mnuBaiB4.Name = "mnuBaiB4";
            mnuBaiB4.Size = new Size(125, 26);
            mnuBaiB4.Text = "Bài 4";
            mnuBaiB4.Click += MnuBaiB4_Click;
            // 
            // mnuBaiB5
            // 
            mnuBaiB5.Name = "mnuBaiB5";
            mnuBaiB5.Size = new Size(125, 26);
            mnuBaiB5.Text = "Bài 5";
            mnuBaiB5.Click += MnuBaiB5_Click;
            // 
            // mnuBaiB6
            // 
            mnuBaiB6.Name = "mnuBaiB6";
            mnuBaiB6.Size = new Size(125, 26);
            mnuBaiB6.Text = "Bài 6";
            mnuBaiB6.Click += MnuBaiB6_Click;
            // 
            // mnuBaiB7
            // 
            mnuBaiB7.Name = "mnuBaiB7";
            mnuBaiB7.Size = new Size(125, 26);
            mnuBaiB7.Text = "Bài 7";
            mnuBaiB7.Click += MnuBaiB7_Click;
            // 
            // mnuPhanD
            // 
            mnuPhanD.DropDownItems.AddRange(new ToolStripItem[] { mnuBaiD1, mnuBaiD2, mnuBaiD3 });
            mnuPhanD.Name = "mnuPhanD";
            mnuPhanD.Size = new Size(70, 24);
            mnuPhanD.Text = "Phần D";
            // 
            // mnuBaiD1
            // 
            mnuBaiD1.Name = "mnuBaiD1";
            mnuBaiD1.Size = new Size(224, 26);
            mnuBaiD1.Text = "Bài 1";
            mnuBaiD1.Click += MnuBaiD1_Click;
            // 
            // mnuBaiD2
            // 
            mnuBaiD2.Name = "mnuBaiD2";
            mnuBaiD2.Size = new Size(224, 26);
            mnuBaiD2.Text = "Bài 2";
            mnuBaiD2.Click += MnuBaiD2_Click;
            // 
            // mnuBaiD3
            // 
            mnuBaiD3.Name = "mnuBaiD3";
            mnuBaiD3.Size = new Size(224, 26);
            mnuBaiD3.Text = "Bài 3";
            mnuBaiD3.Click += MnuBaiD3_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Location = new Point(0, 362);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(783, 22);
            statusStripMain.TabIndex = 1;
            // 
            // main
            // 
            ClientSize = new Size(783, 384);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            Font = new Font("Segoe UI", 9.5F);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Name = "main";
            Text = "BÀI TẬP THẢO LUẬN ";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMDI_FormClosing;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MnuBaiA1_Click(object? sender, EventArgs e) => MoFormCon<phana.bai1>();
        private void MnuBaiA2_Click(object? sender, EventArgs e) => MoFormCon<phana.bai2>();
        private void MnuBaiA3_Click(object? sender, EventArgs e) => MoFormCon<phana.bai3>();
        private void MnuBaiA4_Click(object? sender, EventArgs e) => MoFormCon<phana.bai4>();

        private void MnuBaiB1_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai1>();
        private void MnuBaiB2_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai2>();
        private void MnuBaiB3_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai3>();
        private void MnuBaiB4_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai4>();
        private void MnuBaiB5_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai5>();
        private void MnuBaiB6_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai6>();
        private void MnuBaiB7_Click(object? sender, EventArgs e) => MoFormCon<phanb.bai7>();

        private void MnuBaiD1_Click(object? sender, EventArgs e) => MoFormCon<phand.bai1>();
        private void MnuBaiD2_Click(object? sender, EventArgs e) => MoFormCon<phand.bai2>();
        private void MnuBaiD3_Click(object? sender, EventArgs e) => MoFormCon<phand.bai3>();

        

        

        private void FormMDI_FormClosing(object? sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void lblStatusText_Click(object sender, EventArgs e)
        {

        }

        private void MoFormCon<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate();
                    if (child.WindowState == FormWindowState.Minimized)
                    {
                        child.WindowState = FormWindowState.Normal;
                    }
                    return;
                }
            }

            T form = new T();
            form.MdiParent = this;
            form.Show();
           
        }
    }
}
