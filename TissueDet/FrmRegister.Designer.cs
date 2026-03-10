
namespace TissueDet
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMachineCode = new Sunny.UI.UITextBox();
            this.txtLicenseKey = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachineCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineCode.Location = new System.Drawing.Point(87, 131);
            this.txtMachineCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMachineCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtMachineCode.ShowText = false;
            this.txtMachineCode.Size = new System.Drawing.Size(773, 102);
            this.txtMachineCode.TabIndex = 0;
            this.txtMachineCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMachineCode.Watermark = "";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLicenseKey.Location = new System.Drawing.Point(90, 334);
            this.txtLicenseKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLicenseKey.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Padding = new System.Windows.Forms.Padding(5);
            this.txtLicenseKey.ShowText = false;
            this.txtLicenseKey.Size = new System.Drawing.Size(773, 102);
            this.txtLicenseKey.TabIndex = 3;
            this.txtLicenseKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLicenseKey.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "机器码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(83, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "注册码：";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(690, 542);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(201, 82);
            this.uiButton1.TabIndex = 6;
            this.uiButton1.Text = "确定";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1047, 714);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.txtMachineCode);
            this.Name = "FrmRegister";
            this.Text = "注册";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 970, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox txtMachineCode;
        private Sunny.UI.UITextBox txtLicenseKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton uiButton1;
    }
}