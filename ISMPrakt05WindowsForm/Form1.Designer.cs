
namespace ISMPrakt05WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultButton = new System.Windows.Forms.Button();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_totalnum = new System.Windows.Forms.TextBox();
            this.textBox_index = new System.Windows.Forms.TextBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.numericUpDownArrSize = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewArr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Crimson;
            this.ResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResultButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultButton.Location = new System.Drawing.Point(272, 78);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(139, 37);
            this.ResultButton.TabIndex = 0;
            this.ResultButton.Text = "Порахувати";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(540, 216);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.Size = new System.Drawing.Size(125, 27);
            this.textBox_res.TabIndex = 2;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(540, 258);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(125, 27);
            this.textBox_max.TabIndex = 3;
            // 
            // textBox_totalnum
            // 
            this.textBox_totalnum.Location = new System.Drawing.Point(540, 299);
            this.textBox_totalnum.Name = "textBox_totalnum";
            this.textBox_totalnum.Size = new System.Drawing.Size(125, 27);
            this.textBox_totalnum.TabIndex = 4;
            // 
            // textBox_index
            // 
            this.textBox_index.Location = new System.Drawing.Point(540, 338);
            this.textBox_index.Name = "textBox_index";
            this.textBox_index.Size = new System.Drawing.Size(125, 27);
            this.textBox_index.TabIndex = 5;
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(540, 379);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(125, 27);
            this.textBox_num.TabIndex = 6;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(540, 422);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(125, 27);
            this.textBox_sum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введіть розмір масиву (розмір>0): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сума від’ємних елементів масиву:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Максимальний серед парних елементів масиву:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Добуток елементів масиву, що мають парні індекси:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер (індекс) максимального елемента масиву:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Максимальний за модулем елемент масиву:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сума індексів додатних елементів:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(33, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Кількість непарних елементів масиву:";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(540, 465);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(125, 27);
            this.textBox_total.TabIndex = 16;
            // 
            // numericUpDownArrSize
            // 
            this.numericUpDownArrSize.Location = new System.Drawing.Point(527, 30);
            this.numericUpDownArrSize.Name = "numericUpDownArrSize";
            this.numericUpDownArrSize.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownArrSize.TabIndex = 18;
            // 
            // dataGridViewArr
            // 
            this.dataGridViewArr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArr.Location = new System.Drawing.Point(33, 121);
            this.dataGridViewArr.Name = "dataGridViewArr";
            this.dataGridViewArr.RowHeadersWidth = 51;
            this.dataGridViewArr.RowTemplate.Height = 29;
            this.dataGridViewArr.Size = new System.Drawing.Size(695, 72);
            this.dataGridViewArr.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.ResultButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.dataGridViewArr);
            this.Controls.Add(this.numericUpDownArrSize);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.textBox_index);
            this.Controls.Add(this.textBox_totalnum);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.ResultButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завдання про масиви";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_totalnum;
        private System.Windows.Forms.TextBox textBox_index;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.NumericUpDown numericUpDownArrSize;
        private System.Windows.Forms.DataGridView dataGridViewArr;
    }
}

