namespace LifeIdea.LazyCure.UI
{
    partial class TimeLogEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLogEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timeLogView = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timeLogView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLogView
            // 
            this.timeLogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeLogView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Start,
            this.Activity,
            this.Duration,
            this.End});
            resources.ApplyResources(this.timeLogView, "timeLogView");
            this.timeLogView.Name = "timeLogView";
            dataGridViewCellStyle8.NullValue = null;
            this.timeLogView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.timeLogView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.timeLogView_DataError);
            this.timeLogView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timeLogView_KeyUp);
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            dataGridViewCellStyle5.Format = "T";
            dataGridViewCellStyle5.NullValue = null;
            this.Start.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Start, "Start");
            this.Start.Name = "Start";
            this.Start.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Activity
            // 
            this.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activity.DataPropertyName = "Activity";
            resources.ApplyResources(this.Activity, "Activity");
            this.Activity.Name = "Activity";
            this.Activity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            dataGridViewCellStyle6.Format = "T";
            dataGridViewCellStyle6.NullValue = null;
            this.Duration.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Duration, "Duration");
            this.Duration.Name = "Duration";
            this.Duration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // End
            // 
            this.End.DataPropertyName = "End";
            dataGridViewCellStyle7.Format = "T";
            this.End.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.End, "End");
            this.End.Name = "End";
            this.End.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimeLogEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLogView);
            this.MinimizeBox = false;
            this.Name = "TimeLogEditor";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.timeLogView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView timeLogView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
    }
}