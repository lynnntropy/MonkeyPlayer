namespace MonkeyGamerGUI
{
    partial class Form1
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
            this.testListView = new System.Windows.Forms.ListView();
            this.keyNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keyCodeheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scrollWheelCheckbox = new System.Windows.Forms.CheckBox();
            this.mouseClickCheckbox = new System.Windows.Forms.CheckBox();
            this.mouseMovementCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyHoldDurationPicker = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.keystrokeDelayPicker = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.keystrokeNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.startEmulationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyHoldDurationPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keystrokeDelayPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keystrokeNumberPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // testListView
            // 
            this.testListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.keyNameColumn,
            this.keyCodeheader});
            this.testListView.Location = new System.Drawing.Point(12, 27);
            this.testListView.Name = "testListView";
            this.testListView.Size = new System.Drawing.Size(360, 208);
            this.testListView.TabIndex = 0;
            this.testListView.UseCompatibleStateImageBehavior = false;
            this.testListView.View = System.Windows.Forms.View.Details;
            // 
            // keyNameColumn
            // 
            this.keyNameColumn.Text = "Key Name";
            this.keyNameColumn.Width = 113;
            // 
            // keyCodeheader
            // 
            this.keyCodeheader.Text = "Key Code";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(269, 241);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(103, 23);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Start Recording";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keys to use when emulating:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scrollWheelCheckbox);
            this.groupBox1.Controls.Add(this.mouseClickCheckbox);
            this.groupBox1.Controls.Add(this.mouseMovementCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse input configuration";
            // 
            // scrollWheelCheckbox
            // 
            this.scrollWheelCheckbox.AutoSize = true;
            this.scrollWheelCheckbox.Location = new System.Drawing.Point(7, 66);
            this.scrollWheelCheckbox.Name = "scrollWheelCheckbox";
            this.scrollWheelCheckbox.Size = new System.Drawing.Size(174, 17);
            this.scrollWheelCheckbox.TabIndex = 2;
            this.scrollWheelCheckbox.Text = "Emulate scroll wheel movement";
            this.scrollWheelCheckbox.UseVisualStyleBackColor = true;
            // 
            // mouseClickCheckbox
            // 
            this.mouseClickCheckbox.AutoSize = true;
            this.mouseClickCheckbox.Location = new System.Drawing.Point(7, 43);
            this.mouseClickCheckbox.Name = "mouseClickCheckbox";
            this.mouseClickCheckbox.Size = new System.Drawing.Size(128, 17);
            this.mouseClickCheckbox.TabIndex = 1;
            this.mouseClickCheckbox.Text = "Emulate mouse clicks";
            this.mouseClickCheckbox.UseVisualStyleBackColor = true;
            // 
            // mouseMovementCheckbox
            // 
            this.mouseMovementCheckbox.AutoSize = true;
            this.mouseMovementCheckbox.Location = new System.Drawing.Point(7, 20);
            this.mouseMovementCheckbox.Name = "mouseMovementCheckbox";
            this.mouseMovementCheckbox.Size = new System.Drawing.Size(150, 17);
            this.mouseMovementCheckbox.TabIndex = 0;
            this.mouseMovementCheckbox.Text = "Emulate mouse movement";
            this.mouseMovementCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.keyHoldDurationPicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.keystrokeDelayPicker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.keystrokeNumberPicker);
            this.groupBox2.Location = new System.Drawing.Point(12, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emulation preferences";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Key hold duration (in seconds - 0 means instant release)";
            // 
            // keyHoldDurationPicker
            // 
            this.keyHoldDurationPicker.DecimalPlaces = 3;
            this.keyHoldDurationPicker.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.keyHoldDurationPicker.Location = new System.Drawing.Point(303, 72);
            this.keyHoldDurationPicker.Name = "keyHoldDurationPicker";
            this.keyHoldDurationPicker.Size = new System.Drawing.Size(51, 20);
            this.keyHoldDurationPicker.TabIndex = 4;
            this.keyHoldDurationPicker.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Delay between keystrokes (in seconds)";
            // 
            // keystrokeDelayPicker
            // 
            this.keystrokeDelayPicker.DecimalPlaces = 3;
            this.keystrokeDelayPicker.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.keystrokeDelayPicker.Location = new System.Drawing.Point(303, 46);
            this.keystrokeDelayPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.keystrokeDelayPicker.Name = "keystrokeDelayPicker";
            this.keystrokeDelayPicker.Size = new System.Drawing.Size(51, 20);
            this.keystrokeDelayPicker.TabIndex = 2;
            this.keystrokeDelayPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of keystrokes to emulate (0 means infinity)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // keystrokeNumberPicker
            // 
            this.keystrokeNumberPicker.Location = new System.Drawing.Point(303, 19);
            this.keystrokeNumberPicker.Name = "keystrokeNumberPicker";
            this.keystrokeNumberPicker.Size = new System.Drawing.Size(51, 20);
            this.keystrokeNumberPicker.TabIndex = 0;
            // 
            // startEmulationButton
            // 
            this.startEmulationButton.Location = new System.Drawing.Point(12, 476);
            this.startEmulationButton.Name = "startEmulationButton";
            this.startEmulationButton.Size = new System.Drawing.Size(360, 23);
            this.startEmulationButton.TabIndex = 7;
            this.startEmulationButton.Text = "Begin emulating!";
            this.startEmulationButton.UseVisualStyleBackColor = true;
            this.startEmulationButton.Click += new System.EventHandler(this.startEmulationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.startEmulationButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonkeyPlayer 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyHoldDurationPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keystrokeDelayPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keystrokeNumberPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView testListView;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ColumnHeader keyNameColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader keyCodeheader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox scrollWheelCheckbox;
        private System.Windows.Forms.CheckBox mouseClickCheckbox;
        private System.Windows.Forms.CheckBox mouseMovementCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown keystrokeNumberPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown keystrokeDelayPicker;
        private System.Windows.Forms.Button startEmulationButton;
        private System.Windows.Forms.NumericUpDown keyHoldDurationPicker;
        private System.Windows.Forms.Label label4;
    }
}

