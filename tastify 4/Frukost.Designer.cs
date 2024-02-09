
namespace tastify_4
{
    partial class Frukost
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Hem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Stäng = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kylskåp = new System.Windows.Forms.Button();
            this.Middag = new System.Windows.Forms.Button();
            this.Lunch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Stäng);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 53);
            this.panel2.TabIndex = 13;
            // 
            // Hem
            // 
            this.Hem.FlatAppearance.BorderSize = 0;
            this.Hem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hem.ForeColor = System.Drawing.SystemColors.Control;
            this.Hem.Location = new System.Drawing.Point(11, 531);
            this.Hem.Name = "Hem";
            this.Hem.Size = new System.Drawing.Size(182, 33);
            this.Hem.TabIndex = 17;
            this.Hem.Text = "Hem";
            this.Hem.UseVisualStyleBackColor = true;
            this.Hem.Click += new System.EventHandler(this.Hem_Click);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.Hem);
            this.panel1.Controls.Add(this.Kylskåp);
            this.panel1.Controls.Add(this.Middag);
            this.panel1.Controls.Add(this.Lunch);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1080);
            this.panel1.TabIndex = 12;
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
            this.Lunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lunch.FlatAppearance.BorderSize = 0;
            this.Lunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lunch.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunch.ForeColor = System.Drawing.Color.White;
            this.Lunch.Location = new System.Drawing.Point(0, 63);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(193, 56);
            this.Lunch.TabIndex = 0;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = true;
            this.Lunch.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 379);
            this.dataGridView1.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.Location = new System.Drawing.Point(248, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(667, 56);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Rekomenderade frukostar för dig";
            // 
            // Frukost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frukost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frukost";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Stäng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Hem;
        private System.Windows.Forms.Button Lunch;
        private System.Windows.Forms.Button Kylskåp;
        private System.Windows.Forms.Button Middag;
    }
}