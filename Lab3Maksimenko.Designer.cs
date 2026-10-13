namespace Lab3_Maksimenko
{
    partial class Lab3Maksimenko
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDraw;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1780, 950);
            this.panel1.TabIndex = 0;

            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 35);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать файл";
            this.btnCreate.UseVisualStyleBackColor = true;

            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(175, 15);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(180, 35);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Считать и вывести";
            this.btnDraw.UseVisualStyleBackColor = true;

            // 
            // Lab3Maksimenko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1050);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Name = "Lab3Maksimenko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab3 Maksimenko";

            this.ResumeLayout(false);
        }
    }
}