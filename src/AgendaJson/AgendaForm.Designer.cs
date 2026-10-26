namespace AgendaJson;

partial class AgendaForm
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblTitulo = null!;
    private Label lblRuta = null!;
    private DataGridView gridContactos = null!;
    private Label lblNombre = null!;
    private TextBox txtNombre = null!;
    private Label lblTelefono = null!;
    private TextBox txtTelefono = null!;
    private Button btnAgregar = null!;
    private Label lblEstado = null!;
    private Button btnGuardar = null!;
    private Button btnCargar = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblRuta = new Label();
        gridContactos = new DataGridView();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        btnAgregar = new Button();
        lblEstado = new Label();
        btnGuardar = new Button();
        btnCargar = new Button();
        ((System.ComponentModel.ISupportInitialize)gridContactos).BeginInit();
        SuspendLayout();

        // lblTitulo
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
        lblTitulo.Location = new Point(24, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Text = "Agenda de contactos";

        // lblRuta
        lblRuta.AutoEllipsis = true;
        lblRuta.ForeColor = Color.FromArgb(96, 96, 96);
        lblRuta.Location = new Point(26, 56);
        lblRuta.Name = "lblRuta";
        lblRuta.Size = new Size(724, 18);
        lblRuta.Text = "";

        // gridContactos
        gridContactos.AllowUserToAddRows = false;
        gridContactos.AllowUserToDeleteRows = false;
        gridContactos.AllowUserToResizeRows = false;
        gridContactos.AutoGenerateColumns = false;
        gridContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridContactos.BackgroundColor = SystemColors.Window;
        gridContactos.BorderStyle = BorderStyle.FixedSingle;
        gridContactos.ColumnHeadersHeight = 34;
        gridContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridContactos.Font = new Font("Segoe UI", 11F);
        gridContactos.Location = new Point(26, 84);
        gridContactos.MultiSelect = false;
        gridContactos.Name = "gridContactos";
        gridContactos.RowHeadersVisible = false;
        gridContactos.RowTemplate.Height = 28;
        gridContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridContactos.Size = new Size(724, 244);
        gridContactos.TabIndex = 0;

        DataGridViewTextBoxColumn colNombre = new()
        {
            DataPropertyName = "Nombre",
            FillWeight = 60F,
            HeaderText = "Nombre",
            Name = "colNombre",
        };

        DataGridViewTextBoxColumn colTelefono = new()
        {
            DataPropertyName = "Telefono",
            FillWeight = 40F,
            HeaderText = "Teléfono",
            Name = "colTelefono",
        };

        gridContactos.Columns.AddRange(colNombre, colTelefono);

        // lblNombre
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(26, 348);
        lblNombre.Name = "lblNombre";
        lblNombre.Text = "Nombre";

        // txtNombre
        txtNombre.Location = new Point(100, 344);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Ana Gómez";
        txtNombre.Size = new Size(240, 27);
        txtNombre.TabIndex = 1;

        // lblTelefono
        lblTelefono.AutoSize = true;
        lblTelefono.Location = new Point(360, 348);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Text = "Teléfono";

        // txtTelefono
        txtTelefono.Location = new Point(440, 344);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "221 555-0134";
        txtTelefono.Size = new Size(186, 27);
        txtTelefono.TabIndex = 2;

        // btnAgregar
        btnAgregar.Location = new Point(642, 342);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(108, 32);
        btnAgregar.TabIndex = 3;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = true;
        btnAgregar.Click += btnAgregar_Click;

        // lblEstado
        lblEstado.AutoEllipsis = true;
        lblEstado.ForeColor = Color.FromArgb(96, 96, 96);
        lblEstado.Location = new Point(26, 396);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(724, 22);
        lblEstado.Text = "0 contactos en la agenda.";

        // btnGuardar
        btnGuardar.Location = new Point(470, 462);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(130, 36);
        btnGuardar.TabIndex = 4;
        btnGuardar.Text = "Guardar JSON";
        btnGuardar.UseVisualStyleBackColor = true;

        // btnCargar
        btnCargar.Location = new Point(612, 462);
        btnCargar.Name = "btnCargar";
        btnCargar.Size = new Size(138, 36);
        btnCargar.TabIndex = 5;
        btnCargar.Text = "Cargar JSON";
        btnCargar.UseVisualStyleBackColor = true;

        // AgendaForm
        AcceptButton = btnAgregar;
        ClientSize = new Size(776, 520);
        Controls.Add(btnCargar);
        Controls.Add(btnGuardar);
        Controls.Add(lblEstado);
        Controls.Add(btnAgregar);
        Controls.Add(txtTelefono);
        Controls.Add(lblTelefono);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Controls.Add(gridContactos);
        Controls.Add(lblRuta);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(700, 480);
        Name = "AgendaForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Agenda de contactos";
        ((System.ComponentModel.ISupportInitialize)gridContactos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
