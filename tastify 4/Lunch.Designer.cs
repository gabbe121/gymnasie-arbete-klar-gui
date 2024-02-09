
namespace tastify_4
{
    partial class Lunch
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
            this.Frukost = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Hem = new System.Windows.Forms.Button();
            this.Stäng = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kylskåp = new System.Windows.Forms.Button();
            this.Middag = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frukost
            // 
            this.Frukost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Frukost.FlatAppearance.BorderSize = 0;
            this.Frukost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frukost.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frukost.ForeColor = System.Drawing.Color.White;
            this.Frukost.Location = new System.Drawing.Point(0, 63);
            this.Frukost.Name = "Frukost";
            this.Frukost.Size = new System.Drawing.Size(193, 56);
            this.Frukost.TabIndex = 0;
            this.Frukost.Text = "Frukost";
            this.Frukost.UseVisualStyleBackColor = true;
            this.Frukost.Click += new System.EventHandler(this.Frukost_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "TastiFy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Stäng);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 53);
            this.panel2.TabIndex = 22;
            // 
            // Hem
            // 
            this.Hem.FlatAppearance.BorderSize = 0;
            this.Hem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hem.ForeColor = System.Drawing.SystemColors.Control;
            this.Hem.Location = new System.Drawing.Point(3, 543);
            this.Hem.Name = "Hem";
            this.Hem.Size = new System.Drawing.Size(197, 33);
            this.Hem.TabIndex = 17;
            this.Hem.Text = "Hem";
            this.Hem.UseVisualStyleBackColor = true;
            this.Hem.Click += new System.EventHandler(this.Hem_Click_1);
            // 
            // Stäng
            // 
            this.Stäng.FlatAppearance.BorderSize = 0;
            this.Stäng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stäng.ForeColor = System.Drawing.Color.Red;
            this.Stäng.Location = new System.Drawing.Point(908, 5);
            this.Stäng.Name = "Stäng";
            this.Stäng.Size = new System.Drawing.Size(39, 33);
            this.Stäng.TabIndex = 3;
            this.Stäng.Text = "X";
            this.Stäng.UseVisualStyleBackColor = true;
            this.Stäng.Click += new System.EventHandler(this.Stäng_Click_1);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.Location = new System.Drawing.Point(247, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(667, 56);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "Rekomenderad lunch för dig";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 379);
            this.dataGridView1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.Hem);
            this.panel1.Controls.Add(this.Kylskåp);
            this.panel1.Controls.Add(this.Middag);
            this.panel1.Controls.Add(this.Frukost);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1080);
            this.panel1.TabIndex = 21;
            // 
            // Kylskåp
            // 
            this.Kylskåp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kylskåp.FlatAppearance.BorderSize = 0;
            this.Kylskåp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kylskåp.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kylskåp.ForeColor = System.Drawing.Color.White;
            this.Kylskåp.Location = new System.Drawing.Point(0, 197);
            this.Kylskåp.Name = "Kylskåp";
            this.Kylskåp.Size = new System.Drawing.Size(193, 56);
            this.Kylskåp.TabIndex = 2;
            this.Kylskåp.Text = "Kylskåp";
            this.Kylskåp.UseVisualStyleBackColor = true;
            this.Kylskåp.Click += new System.EventHandler(this.Kylskåp_Click);
            // 
            // Middag
            // 
            this.Middag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Middag.FlatAppearance.BorderSize = 0;
            this.Middag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Middag.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middag.ForeColor = System.Drawing.Color.White;
            this.Middag.Location = new System.Drawing.Point(0, 125);
            this.Middag.Name = "Middag";
            this.Middag.Size = new System.Drawing.Size(193, 56);
            this.Middag.TabIndex = 1;
            this.Middag.Text = "Middag";
            this.Middag.UseVisualStyleBackColor = true;
            this.Middag.Click += new System.EventHandler(this.Middag_Click);
            // 
            // Lunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Frukost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Hem;
        private System.Windows.Forms.Button Stäng;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Kylskåp;
        private System.Windows.Forms.Button Middag;
    }
}