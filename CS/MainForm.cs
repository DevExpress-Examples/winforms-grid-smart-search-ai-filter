using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using SmartAIFilter.Provider;
using System.Collections.Concurrent;

namespace SmartAIFilter {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
            itemBindingSource.DataSource = Item.GetAllItems();
        }
        void OnCustomRowFilter(object sender, RowFilterEventArgs e) {
            Item? item = ((ColumnView)sender).DataController.GetRowByListSourceIndex(e.ListSourceRow) as Item;
            if(item == null)
                return;
            string filter = teFilter.Text;
            if(string.IsNullOrEmpty(filter))
                return;
            float threshold = (float)tbThreshold.Value / 100;
            e.Visible = SmartFilterProvider.IsSimilarTo(filter, item.Name, threshold);
            if(!e.Visible && cbIncludeDescription.Checked)
                e.Visible = SmartFilterProvider.IsSimilarTo(filter, item.Description, threshold);
            e.Handled = true;
        }

        void OnFilter(object sender, EventArgs e) {
            gridView1.RefreshData();
        }

        void OnThresholdChanged(object sender, EventArgs e) {
            gridView1.RefreshData();
        }

        void OnIncludeDescriptionChanged(object sender, EventArgs e) {
            gridView1.RefreshData();
        }

        void teFilter_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                OnFilter(sender, e);
        }
    }
}
namespace SmartAIFilter.Provider {
    using SmartComponents.LocalEmbeddings;

    public static class SmartFilterProvider {
        readonly static LocalEmbedder Embedder = new LocalEmbedder(caseSensitive: false);
        readonly static ConcurrentDictionary<string, EmbeddingF32> cache =
            new ConcurrentDictionary<string, EmbeddingF32>(StringComparer.OrdinalIgnoreCase);
        public static bool IsSimilarTo(string filter, string text, float threshold = 0.75f) {
            EmbeddingF32 eText = cache.GetOrAdd(text, x => Embedder.Embed(x));
            EmbeddingF32 eFilter = cache.GetOrAdd(filter, x => Embedder.Embed(x));
            return eFilter.Similarity(eText) > threshold;
        }
    }
}
