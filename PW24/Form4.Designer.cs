namespace PW24
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonCtan = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(95, 35);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(100, 26);
            this.textBoxAngle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Угол:";
            // 
            // buttonSin
            // 
            this.buttonSin.Location = new System.Drawing.Point(23, 80);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(91, 34);
            this.buttonSin.TabIndex = 2;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.Location = new System.Drawing.Point(120, 80);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(87, 34);
            this.buttonCos.TabIndex = 3;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.Location = new System.Drawing.Point(23, 120);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(91, 35);
            this.buttonTan.TabIndex = 4;
            this.buttonTan.Text = "Tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.buttonTan_Click);
            // 
            // buttonCtan
            // 
            this.buttonCtan.Location = new System.Drawing.Point(120, 120);
            this.buttonCtan.Name = "buttonCtan";
            this.buttonCtan.Size = new System.Drawing.Size(87, 35);
            this.buttonCtan.TabIndex = 5;
            this.buttonCtan.Text = "Ctan";
            this.buttonCtan.UseVisualStyleBackColor = true;
            this.buttonCtan.Click += new System.EventHandler(this.buttonCtan_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 160);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вернуться в меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(333, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCtan);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAngle);
            this.Name = "Form4";
            this.Text = "Тригонометрический калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonCtan;
        private System.Windows.Forms.Label labelResult;

        #endregion

        private System.Windows.Forms.Button button1;
    }
}