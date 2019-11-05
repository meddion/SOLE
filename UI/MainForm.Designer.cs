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
            this.methodSelector.BackColor = System.Drawing.SystemColors.InfoText;
            this.methodSelector.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodSelector.ForeColor = System.Drawing.SystemColors.Window;
            this.methodSelector.FormattingEnabled = true;
            this.methodSelector.Items.AddRange(new object[] {
            "Гаус-Зейдель",
            "Верхні релаксації",
            "LU",
            "Халецький"});
            this.methodSelector.Location = new System.Drawing.Point(62, 5);
            this.methodSelector.Margin = new System.Windows.Forms.Padding(2);
            this.methodSelector.Name = "methodSelector";
            this.methodSelector.Size = new System.Drawing.Size(206, 27);
            this.methodSelector.TabIndex = 0;
            this.methodSelector.SelectedIndexChanged += new System.EventHandler(this.methodSelector_SelectedIndexChanged);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.logBox.Location = new System.Drawing.Point(9, 351);
            this.logBox.Margin = new System.Windows.Forms.Padding(2);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(565, 70);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matrixGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGrid.ColumnHeadersVisible = false;
            this.matrixGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matrixGrid.Location = new System.Drawing.Point(10, 36);
            this.matrixGrid.Margin = new System.Windows.Forms.Padding(2);
            this.matrixGrid.Name = "matrixGrid";
            this.matrixGrid.RowHeadersVisible = false;
            this.matrixGrid.RowHeadersWidth = 51;
            this.matrixGrid.RowTemplate.Height = 24;
            this.matrixGrid.Size = new System.Drawing.Size(338, 310);
            this.matrixGrid.TabIndex = 2;
            // 
            // vectorBGrid
            // 
            this.vectorBGrid.AllowUserToAddRows = false;
            this.vectorBGrid.AllowUserToDeleteRows = false;
            this.vectorBGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vectorBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vectorBGrid.ColumnHeadersVisible = false;
            this.vectorBGrid.GridColor = System.Drawing.SystemColors.Control;
            this.vectorBGrid.Location = new System.Drawing.Point(352, 36);
            this.vectorBGrid.Margin = new System.Windows.Forms.Padding(2);
            this.vectorBGrid.Name = "vectorBGrid";
            this.vectorBGrid.RowHeadersVisible = false;
            this.vectorBGrid.RowHeadersWidth = 51;
            this.vectorBGrid.RowTemplate.Height = 24;
            this.vectorBGrid.Size = new System.Drawing.Size(111, 310);
            this.vectorBGrid.TabIndex = 3;
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.AllowUserToResizeColumns = false;
            this.resultGrid.AllowUserToResizeRows = false;
            this.resultGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.ColumnHeadersVisible = false;
            this.resultGrid.GridColor = System.Drawing.SystemColors.Control;
            this.resultGrid.Location = new System.Drawing.Point(467, 36);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(2);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowHeadersVisible = false;
            this.resultGrid.RowHeadersWidth = 51;
            this.resultGrid.RowTemplate.Height = 24;
            this.resultGrid.Size = new System.Drawing.Size(106, 310);
            this.resultGrid.TabIndex = 4;
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.size.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.ForeColor = System.Drawing.SystemColors.Window;
            this.size.Location = new System.Drawing.Point(322, 6);
            this.size.Margin = new System.Windows.Forms.Padding(2);
            this.size.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(90, 26);
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
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Метод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Розмір";
            // 
            // randomMatrix
            // 
            this.randomMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomMatrix.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomMatrix.Location = new System.Drawing.Point(416, 5);
            this.randomMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.randomMatrix.Name = "randomMatrix";
            this.randomMatrix.Size = new System.Drawing.Size(157, 26);
            this.randomMatrix.TabIndex = 8;
            this.randomMatrix.Text = "Випадкова матриця";
            this.randomMatrix.UseVisualStyleBackColor = true;
            this.randomMatrix.Click += new System.EventHandler(this.randomMatrix_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(582, 430);
            this.Controls.Add(this.randomMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.vectorBGrid);
            this.Controls.Add(this.matrixGrid);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.methodSelector);
            this.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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

