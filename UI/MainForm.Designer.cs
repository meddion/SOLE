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
            this.methodSelector = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.vectorBGrid = new System.Windows.Forms.DataGridView();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randomMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorBGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            this.SuspendLayout();
            // 
            // methodSelector
            // 
            this.methodSelector.FormattingEnabled = true;
            this.methodSelector.Items.AddRange(new object[] {
            "Гаус-Зейдель",
            "Верхні релаксації",
            "LU",
            "Халецький"});
            this.methodSelector.Location = new System.Drawing.Point(69, 12);
            this.methodSelector.Name = "methodSelector";
            this.methodSelector.Size = new System.Drawing.Size(296, 24);
            this.methodSelector.TabIndex = 0;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 432);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(752, 85);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGrid.ColumnHeadersVisible = false;
            this.matrixGrid.Location = new System.Drawing.Point(13, 44);
            this.matrixGrid.Name = "matrixGrid";
            this.matrixGrid.RowHeadersVisible = false;
            this.matrixGrid.RowHeadersWidth = 51;
            this.matrixGrid.RowTemplate.Height = 24;
            this.matrixGrid.Size = new System.Drawing.Size(450, 382);
            this.matrixGrid.TabIndex = 2;
            // 
            // vectorBGrid
            // 
            this.vectorBGrid.AllowUserToAddRows = false;
            this.vectorBGrid.AllowUserToDeleteRows = false;
            this.vectorBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vectorBGrid.ColumnHeadersVisible = false;
            this.vectorBGrid.Location = new System.Drawing.Point(469, 44);
            this.vectorBGrid.Name = "vectorBGrid";
            this.vectorBGrid.RowHeadersVisible = false;
            this.vectorBGrid.RowHeadersWidth = 51;
            this.vectorBGrid.RowTemplate.Height = 24;
            this.vectorBGrid.Size = new System.Drawing.Size(148, 382);
            this.vectorBGrid.TabIndex = 3;
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.AllowUserToResizeColumns = false;
            this.resultGrid.AllowUserToResizeRows = false;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.ColumnHeadersVisible = false;
            this.resultGrid.Location = new System.Drawing.Point(623, 44);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowHeadersVisible = false;
            this.resultGrid.RowHeadersWidth = 51;
            this.resultGrid.RowTemplate.Height = 24;
            this.resultGrid.Size = new System.Drawing.Size(141, 382);
            this.resultGrid.TabIndex = 4;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(429, 14);
            this.size.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(120, 22);
            this.size.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Метод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Розмір";
            // 
            // randomMatrix
            // 
            this.randomMatrix.Location = new System.Drawing.Point(555, 12);
            this.randomMatrix.Name = "randomMatrix";
            this.randomMatrix.Size = new System.Drawing.Size(209, 26);
            this.randomMatrix.TabIndex = 8;
            this.randomMatrix.Text = "Випадкова матриця";
            this.randomMatrix.UseVisualStyleBackColor = true;
            this.randomMatrix.Click += new System.EventHandler(this.randomMatrix_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 529);
            this.Controls.Add(this.randomMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.vectorBGrid);
            this.Controls.Add(this.matrixGrid);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.methodSelector);
            this.Name = "MainForm";
            this.Text = "Dont touch my tralala";
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorBGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox methodSelector;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.DataGridView vectorBGrid;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button randomMatrix;
    }
}

