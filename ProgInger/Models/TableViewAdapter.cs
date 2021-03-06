using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace ProgInger
{
    class TableViewAdapter
    {

        private DataGridView view;

        public TableViewAdapter(DataGridView view)
        {
            this.view = view;
        }

        public void initColumns(string[][] columns, int[] widths)
        {

            for (int i = 0; i < columns.Length; i++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name = columns[i][0];
                col.HeaderText = columns[i][1];
                col.CellTemplate = new DataGridViewTextBoxCell();
                col.Width = widths[i];
                view.Columns.Insert(i, col);
            }
        }

        public void pushRowsInGridView(List<MoneyChangeItem> items)
        {
            items.ForEach((MoneyChangeItem item) => {
                view.Rows.Add(item.Id, item.DateTime, item.Goal, item.Money);
            });
        }


        public void setRows(List<MoneyChangeItem> items)
        {
            view.Rows.Clear();

            items.ForEach((MoneyChangeItem item) => {
                view.Rows.Add(item.Id, item.DateTime, item.Goal, item.Money);
            });
        }
    }
}
