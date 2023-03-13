namespace Colletta_internazionale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lista = new Dictionary<Partecipante, Importo>();
        }
        Dictionary<Partecipante, Importo> Lista;

        private void Form1_Load(object sender, EventArgs e)
        {
            listView.Columns.Add("Nome   ");
            listView.Columns.Add("Importo");
            listView.Columns.Add("Valuta ");    
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            string nome, valuta;
            double importo = -1;
            Importo i;
            Partecipante p;
            try
            {
                nome = textBoxNome.Text;
                valuta = textBoxValuta.Text;
                importo = Convert.ToDouble(textBoxImporto.Text);
                i = new Importo(importo, valuta);
                p = new Partecipante(nome);
            } 
            catch(Exception) { MessageBox.Show("Parametri invalidi"); return; }

            if (Lista.ContainsKey(p))
            { }
            else
            {
                Lista.Add(p, i);
                string[] str = new string[] { nome, importo.ToString(), valuta };
                ListViewItem riga = new ListViewItem(str);
                listView.Items.Add(riga);
            }
        }

        private void buttonCercaimporto_Click(object sender, EventArgs e)
        {
            double imp = 0;
            string vl;
            Importo i = new Importo(0, "vl");
            try { 
                imp = Convert.ToDouble(textBoxImporto.Text);
                vl = textBoxValuta.Text;
                i = new Importo(imp, vl);
            }
            catch (Exception) { MessageBox.Show("Importo invalido"); }
            if (Lista.ContainsValue(i)) 
            { 

            }

            else MessageBox.Show("Nessuno ha versato questo importo");
            
        }

        private void buttonOrdinaimporto_Click(object sender, EventArgs e)
        {
            
            //RefreshListView();
        }
        
        private void buttonOrdinanome_Click(object sender, EventArgs e)
        {
            SortedDictionary<Partecipante, Importo> s = new SortedDictionary<Partecipante, Importo>(Lista);
            RefreshListView(s);
        }
        private void RefreshListView(SortedDictionary<Partecipante, Importo> tabella)
        {
            listView.Clear();
            listView.Columns.Add("Nome   ");
            listView.Columns.Add("Importo");
            listView.Columns.Add("Valuta ");
            ListViewItem riga = new ListViewItem();
            string[] str = new string[3];
            foreach(KeyValuePair<Partecipante, Importo> rig in tabella)
            {
                str[0] = rig.Key.Nome;
                str[1] = rig.Value.Valore+"";
                str[2] = rig.Value.Valuta;
                riga = new ListViewItem(str);
                listView.Items.Add(riga);
            }
        }
    }
}