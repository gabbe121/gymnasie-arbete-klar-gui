
namespace tastify_4
{
    partial class Kylskåp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Stäng = new System.Windows.Forms.Button();
            this.Hem = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Frukost = new System.Windows.Forms.Button();
            this.Middag = new System.Windows.Forms.Button();
            this.Lunch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 53);
            this.panel2.TabIndex = 18;
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
            // Hem
            // 
            this.Hem.FlatAppearance.BorderSize = 0;
            this.Hem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hem.ForeColor = System.Drawing.SystemColors.Control;
            this.Hem.Location = new System.Drawing.Point(0, 532);
            this.Hem.Name = "Hem";
            this.Hem.Size = new System.Drawing.Size(200, 33);
            this.Hem.TabIndex = 17;
            this.Hem.Text = "Hem";
            this.Hem.UseVisualStyleBackColor = true;
            this.Hem.Click += new System.EventHandler(this.Hem_Click_1);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.Location = new System.Drawing.Point(247, 63);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(667, 56);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Allt i ditt kylskåp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 379);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.Hem);
            this.panel1.Controls.Add(this.Frukost);
            this.panel1.Controls.Add(this.Middag);
            this.panel1.Controls.Add(this.Lunch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1080);
            this.panel1.TabIndex = 17;
            // 
            // Frukost
            // 
            this.Frukost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Frukost.FlatAppearance.BorderSize = 0;
            this.Frukost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frukost.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frukost.ForeColor = System.Drawing.Color.White;
            this.Frukost.Location = new System.Drawing.Point(0, 59);
            this.Frukost.Name = "Frukost";
            this.Frukost.Size = new System.Drawing.Size(193, 56);
            this.Frukost.TabIndex = 2;
            this.Frukost.Text = "Frukost";
            this.Frukost.UseVisualStyleBackColor = true;
            this.Frukost.Click += new System.EventHandler(this.Frukost_Click);
            // 
            // Middag
            // 
            this.Middag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Middag.FlatAppearance.BorderSize = 0;
            this.Middag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Middag.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middag.ForeColor = System.Drawing.Color.White;
            this.Middag.Location = new System.Drawing.Point(0, 183);
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
            this.Lunch.Location = new System.Drawing.Point(0, 121);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(193, 56);
            this.Lunch.TabIndex = 0;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = true;
            this.Lunch.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // Kylskåp
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
            this.Name = "Kylskåp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kylskåp";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Hem;
        private System.Windows.Forms.Button Stäng;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Frukost;
        private System.Windows.Forms.Button Middag;
        private System.Windows.Forms.Button Lunch;
    }
}