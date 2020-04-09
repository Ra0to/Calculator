namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.but7 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 4;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.Controls.Add(this.equal, 0, 5);
            this.layout.Controls.Add(this.dot, 2, 4);
            this.layout.Controls.Add(this.but0, 1, 4);
            this.layout.Controls.Add(this.ce, 0, 4);
            this.layout.Controls.Add(this.multi, 3, 3);
            this.layout.Controls.Add(this.but3, 2, 3);
            this.layout.Controls.Add(this.but2, 1, 3);
            this.layout.Controls.Add(this.but1, 0, 3);
            this.layout.Controls.Add(this.minus, 3, 2);
            this.layout.Controls.Add(this.but6, 2, 2);
            this.layout.Controls.Add(this.but5, 1, 2);
            this.layout.Controls.Add(this.but4, 0, 2);
            this.layout.Controls.Add(this.plus, 3, 1);
            this.layout.Controls.Add(this.but9, 2, 1);
            this.layout.Controls.Add(this.but8, 1, 1);
            this.layout.Controls.Add(this.res, 0, 0);
            this.layout.Controls.Add(this.but7, 0, 1);
            this.layout.Controls.Add(this.div, 3, 4);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 6;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Size = new System.Drawing.Size(284, 361);
            this.layout.TabIndex = 0;
            // 
            // equal
            // 
            this.layout.SetColumnSpan(this.equal, 4);
            this.equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equal.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(3, 303);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(278, 55);
            this.equal.TabIndex = 16;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(145, 243);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(65, 54);
            this.dot.TabIndex = 15;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // but0
            // 
            this.but0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but0.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but0.Location = new System.Drawing.Point(74, 243);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(65, 54);
            this.but0.TabIndex = 14;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // ce
            // 
            this.ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ce.Location = new System.Drawing.Point(3, 243);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(65, 54);
            this.ce.TabIndex = 13;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // multi
            // 
            this.multi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multi.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multi.Location = new System.Drawing.Point(216, 183);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(65, 54);
            this.multi.TabIndex = 12;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // but3
            // 
            this.but3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but3.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but3.Location = new System.Drawing.Point(145, 183);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(65, 54);
            this.but3.TabIndex = 11;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but2
            // 
            this.but2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but2.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.Location = new System.Drawing.Point(74, 183);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(65, 54);
            this.but2.TabIndex = 10;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but1
            // 
            this.but1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.Location = new System.Drawing.Point(3, 183);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(65, 54);
            this.but1.TabIndex = 9;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(216, 123);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(65, 54);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // but6
            // 
            this.but6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but6.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but6.Location = new System.Drawing.Point(145, 123);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(65, 54);
            this.but6.TabIndex = 7;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but5
            // 
            this.but5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but5.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but5.Location = new System.Drawing.Point(74, 123);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(65, 54);
            this.but5.TabIndex = 6;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but4
            // 
            this.but4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but4.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but4.Location = new System.Drawing.Point(3, 123);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(65, 54);
            this.but4.TabIndex = 5;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(216, 63);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(65, 54);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // but9
            // 
            this.but9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but9.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but9.Location = new System.Drawing.Point(145, 63);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(65, 54);
            this.but9.TabIndex = 3;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but8
            // 
            this.but8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but8.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but8.Location = new System.Drawing.Point(74, 63);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(65, 54);
            this.but8.TabIndex = 2;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.layout.SetColumnSpan(this.res, 4);
            this.res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.res.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(3, 0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(278, 60);
            this.res.TabIndex = 0;
            this.res.Text = "0";
            this.res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // but7
            // 
            this.but7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but7.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but7.Location = new System.Drawing.Point(3, 63);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(65, 54);
            this.but7.TabIndex = 1;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // div
            // 
            this.div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div.Location = new System.Drawing.Point(216, 243);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(65, 54);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.layout);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button div;
    }
}

