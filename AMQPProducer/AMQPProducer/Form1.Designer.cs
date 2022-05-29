namespace AMQPProducer
{
    partial class frmProducerPanel
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
            this.txtRSSInput = new System.Windows.Forms.TextBox();
            this.lbRSSInput = new System.Windows.Forms.Label();
            this.cboxTopics = new System.Windows.Forms.ComboBox();
            this.lbTopicSelect = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwRSSList = new System.Windows.Forms.DataGridView();
            this.lbRSSList = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRSSList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRSSInput
            // 
            this.txtRSSInput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRSSInput.Location = new System.Drawing.Point(62, 84);
            this.txtRSSInput.Name = "txtRSSInput";
            this.txtRSSInput.Size = new System.Drawing.Size(535, 43);
            this.txtRSSInput.TabIndex = 0;
            // 
            // lbRSSInput
            // 
            this.lbRSSInput.AutoSize = true;
            this.lbRSSInput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRSSInput.Location = new System.Drawing.Point(62, 44);
            this.lbRSSInput.Name = "lbRSSInput";
            this.lbRSSInput.Size = new System.Drawing.Size(253, 37);
            this.lbRSSInput.TabIndex = 1;
            this.lbRSSInput.Text = "Enter RSS Link Here:";
            // 
            // cboxTopics
            // 
            this.cboxTopics.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxTopics.FormattingEnabled = true;
            this.cboxTopics.Items.AddRange(new object[] {
            "Sports",
            "Technology",
            "Politics",
            "Economy",
            "Magazine"});
            this.cboxTopics.Location = new System.Drawing.Point(62, 202);
            this.cboxTopics.Name = "cboxTopics";
            this.cboxTopics.Size = new System.Drawing.Size(535, 45);
            this.cboxTopics.TabIndex = 2;
            // 
            // lbTopicSelect
            // 
            this.lbTopicSelect.AutoSize = true;
            this.lbTopicSelect.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTopicSelect.Location = new System.Drawing.Point(62, 162);
            this.lbTopicSelect.Name = "lbTopicSelect";
            this.lbTopicSelect.Size = new System.Drawing.Size(411, 37);
            this.lbTopicSelect.TabIndex = 3;
            this.lbTopicSelect.Text = "Select the topic of your RSS Feed:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(512, 617);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwRSSList
            // 
            this.dgwRSSList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRSSList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwRSSList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRSSList.Location = new System.Drawing.Point(62, 335);
            this.dgwRSSList.Name = "dgwRSSList";
            this.dgwRSSList.RowTemplate.Height = 25;
            this.dgwRSSList.Size = new System.Drawing.Size(535, 259);
            this.dgwRSSList.TabIndex = 5;
            // 
            // lbRSSList
            // 
            this.lbRSSList.AutoSize = true;
            this.lbRSSList.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRSSList.Location = new System.Drawing.Point(62, 295);
            this.lbRSSList.Name = "lbRSSList";
            this.lbRSSList.Size = new System.Drawing.Size(108, 37);
            this.lbRSSList.TabIndex = 6;
            this.lbRSSList.Text = "RSS List";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(371, 617);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(12, 617);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(135, 40);
            this.btnPublish.TabIndex = 8;
            this.btnPublish.Text = "Start Publishing";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbError.Location = new System.Drawing.Point(109, 266);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(440, 21);
            this.lbError.TabIndex = 9;
            this.lbError.Text = "One or more fields are empty, cannot insert into RSS List.";
            this.lbError.Visible = false;
            // 
            // frmProducerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 669);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbRSSList);
            this.Controls.Add(this.dgwRSSList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTopicSelect);
            this.Controls.Add(this.cboxTopics);
            this.Controls.Add(this.lbRSSInput);
            this.Controls.Add(this.txtRSSInput);
            this.Name = "frmProducerPanel";
            this.Text = "Producer Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRSSList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRSSInput;
        private Label lbRSSInput;
        private ComboBox cboxTopics;
        private Label lbTopicSelect;
        private Button btnAdd;
        private DataGridView dgwRSSList;
        private Label lbRSSList;
        private Button btnDelete;
        private Button btnPublish;
        private Label lbError;
    }
}