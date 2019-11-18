namespace UI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.methodSelector = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randomMatrix = new System.Windows.Forms.Button();
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.vectorBGrid = new System.Windows.Forms.DataGridView();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorBGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // methodSelector
            // 
            this.methodSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.methodSelector.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.methodSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodSelector.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodSelector.ForeColor = System.Drawing.SystemColors.Window;
            this.methodSelector.ItemHeight = 20;
            this.methodSelector.Items.AddRange(new object[] {
            "LU",
            "Верхні релаксації",
            "Гаус-Зейдель",
            "Халецький"});
            this.methodSelector.Location = new System.Drawing.Point(101, 7);
            this.methodSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.methodSelector.Name = "methodSelector";
            this.methodSelector.Size = new System.Drawing.Size(164, 28);
            this.methodSelector.Sorted = true;
            this.methodSelector.TabIndex = 0;
            this.methodSelector.SelectedIndexChanged += new System.EventHandler(this.methodSelector_SelectedIndexChanged);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.logBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.logBox.Location = new System.Drawing.Point(19, 460);
            this.logBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(811, 73);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.ForeColor = System.Drawing.SystemColors.Window;
            this.size.Location = new System.Drawing.Point(355, 5);
            this.size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.size.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(68, 32);
            this.size.TabIndex = 5;
            this.size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.size.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size.ValueChanged += new System.EventHandler(this.size_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Метод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(267, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Розмір";
            // 
            // randomMatrix
            // 
            this.randomMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomMatrix.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomMatrix.Location = new System.Drawing.Point(477, 7);
            this.randomMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomMatrix.Name = "randomMatrix";
            this.randomMatrix.Size = new System.Drawing.Size(131, 32);
            this.randomMatrix.TabIndex = 8;
            this.randomMatrix.Text = "Random";
            this.randomMatrix.UseVisualStyleBackColor = true;
            this.randomMatrix.Click += new System.EventHandler(this.randomMatrix_Click);
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.AllowUserToResizeRows = false;
            this.matrixGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.matrixGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matrixGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.matrixGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrixGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.matrixGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matrixGrid.Location = new System.Drawing.Point(19, 44);
            this.matrixGrid.Margin = new System.Windows.Forms.Padding(10);
            this.matrixGrid.Name = "matrixGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrixGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.matrixGrid.RowHeadersVisible = false;
            this.matrixGrid.RowHeadersWidth = 20;
            this.matrixGrid.RowTemplate.Height = 25;
            this.matrixGrid.Size = new System.Drawing.Size(404, 404);
            this.matrixGrid.TabIndex = 2;
            // 
            // vectorBGrid
            // 
            this.vectorBGrid.AllowUserToAddRows = false;
            this.vectorBGrid.AllowUserToDeleteRows = false;
            this.vectorBGrid.AllowUserToResizeColumns = false;
            this.vectorBGrid.AllowUserToResizeRows = false;
            this.vectorBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vectorBGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.vectorBGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vectorBGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.vectorBGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vectorBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vectorBGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vectorBGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.vectorBGrid.GridColor = System.Drawing.SystemColors.Control;
            this.vectorBGrid.Location = new System.Drawing.Point(460, 44);
            this.vectorBGrid.Margin = new System.Windows.Forms.Padding(10);
            this.vectorBGrid.Name = "vectorBGrid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vectorBGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vectorBGrid.RowHeadersVisible = false;
            this.vectorBGrid.RowHeadersWidth = 51;
            this.vectorBGrid.RowTemplate.Height = 24;
            this.vectorBGrid.Size = new System.Drawing.Size(168, 404);
            this.vectorBGrid.TabIndex = 3;
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.AllowUserToResizeColumns = false;
            this.resultGrid.AllowUserToResizeRows = false;
            this.resultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.resultGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.resultGrid.GridColor = System.Drawing.SystemColors.Control;
            this.resultGrid.Location = new System.Drawing.Point(666, 44);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.resultGrid.RowHeadersVisible = false;
            this.resultGrid.RowHeadersWidth = 51;
            this.resultGrid.RowTemplate.Height = 24;
            this.resultGrid.Size = new System.Drawing.Size(164, 404);
            this.resultGrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(684, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Рахувати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(851, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.vectorBGrid);
            this.Controls.Add(this.randomMatrix);
            this.Controls.Add(this.matrixGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.methodSelector);
            this.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XIO GOD";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorBGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox methodSelector;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button randomMatrix;
        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.DataGridView vectorBGrid;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Button button1;
    }
}

