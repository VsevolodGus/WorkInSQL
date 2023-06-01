namespace KursachMasha.Forms;

partial class PlayerMatchCountForm
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
        button3 = new Button();
        tablePlayerCountMatchesDataGridView = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)tablePlayerCountMatchesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // button3
        // 
        button3.Location = new Point(12, 195);
        button3.Name = "button3";
        button3.Size = new Size(280, 155);
        button3.TabIndex = 32;
        button3.Text = "Получить список игроков с кол-воматчей в которых они учавствовали";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // tablePlayerCountMatchesDataGridView
        // 
        tablePlayerCountMatchesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayerCountMatchesDataGridView.Location = new Point(298, 12);
        tablePlayerCountMatchesDataGridView.Name = "tablePlayerCountMatchesDataGridView";
        tablePlayerCountMatchesDataGridView.RowHeadersWidth = 51;
        tablePlayerCountMatchesDataGridView.RowTemplate.Height = 29;
        tablePlayerCountMatchesDataGridView.Size = new Size(645, 535);
        tablePlayerCountMatchesDataGridView.TabIndex = 31;
        // 
        // PlayerMatchCountForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(955, 560);
        Controls.Add(button3);
        Controls.Add(tablePlayerCountMatchesDataGridView);
        Name = "PlayerMatchCountForm";
        Text = "PlayerMatchCountForm";
        ((System.ComponentModel.ISupportInitialize)tablePlayerCountMatchesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button button3;
    private DataGridView tablePlayerCountMatchesDataGridView;
}