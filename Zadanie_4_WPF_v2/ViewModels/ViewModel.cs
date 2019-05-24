using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using Zadanie_4_WPF_v2.Models;

namespace Zadanie_4_WPF_v2.ViewModels
{
    class ViewModel : INotifyPropertyChanged
    {
        private DataClassesDataContext aw = new DataClassesDataContext();

        private ObservableCollection<ProductVendor> listProductVendor;
        private ObservableCollection<PurchaseOrderDetail> listPurchaseOrderDetail;
        private ObservableCollection<PurchaseOrderHeader> listPurchaseOrderHeader;
        private ObservableCollection<ShipMethod> listShipMethod;
        private ObservableCollection<Vendor> listVendor;

        public ViewModel()
        {
            listShipMethod = new ObservableCollection<ShipMethod>();
            foreach (ShipMethod shm in aw.ShipMethods)
                listShipMethod.Add(shm);

            listPurchaseOrderHeader = new ObservableCollection<PurchaseOrderHeader>();
            foreach (PurchaseOrderHeader poh in aw.PurchaseOrderHeaders)
                listPurchaseOrderHeader.Add(poh);

            listPurchaseOrderDetail = new ObservableCollection<PurchaseOrderDetail>();
            foreach (PurchaseOrderDetail pod in aw.PurchaseOrderDetails)
                listPurchaseOrderDetail.Add(pod);

            listVendor = new ObservableCollection<Vendor>();
            foreach (Vendor ven in aw.Vendors)
                listVendor.Add(ven);

            listProductVendor = new ObservableCollection<ProductVendor>();
            foreach (ProductVendor pven in aw.ProductVendors)
                listProductVendor.Add(pven);
        }

        public ObservableCollection<ProductVendor> ListProductVendor
        {
            get
            {
                return this.listProductVendor;
            }
            set
            {
                this.listProductVendor = value;
                OnPropertyChanged("ListProductVendor");
            }
        }
        public ObservableCollection<PurchaseOrderDetail> ListPurchaseOrderDetail
        {
            get
            {
                return this.listPurchaseOrderDetail;
            }
            set
            {
                this.listPurchaseOrderDetail = value;
                OnPropertyChanged("ListPurchaseOrderDetail");
            }
        }
        public ObservableCollection<PurchaseOrderHeader> ListPurchaseOrderHeader
        {
            get
            {
                return this.listPurchaseOrderHeader;
            }
            set
            {
                this.listPurchaseOrderHeader = value;
                OnPropertyChanged("ListPurchaseOrderHeader");
            }
        }
        public ObservableCollection<ShipMethod> ListShipMethod
        {
            get
            {
                return this.listShipMethod;
            }
            set
            {
                this.listShipMethod = value;
                OnPropertyChanged("ListShipMethod");
            }
        }
        public ObservableCollection<Vendor> ListVendor
        {
            get
            {
                return this.listVendor;
            }
            set
            {
                this.listVendor = value;
                OnPropertyChanged("ListVendor");
            }
        }

        #region ProductVendor

        private int ProductVendor_ProductID;
        private int ProductVendor_BusinessEntityID;
        private int ProductVendor_AverageLeadTime;
        private decimal ProductVendor_StandardPrice;
        private decimal? ProductVendor_LastReceiptCost;
        private DateTime? ProductVendor_LastReceiptDate;
        private int ProductVendor_MinOrderQty;
        private int ProductVendor_MaxOrderQty;
        private int? ProductVendor_OnOrderQty;
        private string ProductVendor_UnitMeasureCode;
        private DateTime ProductVendor_ModifiedDate;
        private int ProductVendor_selectedIndex = 0;

        public int EditProductVendor_ProductID
        {
            get
            {
                return this.ProductVendor_ProductID;
            }
            set
            {
                this.ProductVendor_ProductID = value;
                OnPropertyChanged("EditProductVendor_ProductID");
            }
        }
        public int EditProductVendor_BusinessEntityID
        {
            get
            {
                return this.ProductVendor_BusinessEntityID;
            }
            set
            {
                this.ProductVendor_BusinessEntityID = value;
                OnPropertyChanged("EditProductVendor_BusinessEntityID");
            }
        }
        public int EditProductVendor_AverageLeadTime
        {
            get
            {
                return this.ProductVendor_AverageLeadTime;
            }
            set
            {
                this.ProductVendor_AverageLeadTime = value;
                OnPropertyChanged("EditProductVendor_AverageLeadTime");
            }
        }
        public decimal EditProductVendor_StandardPrice
        {
            get
            {
                return this.ProductVendor_StandardPrice;
            }
            set
            {
                this.ProductVendor_StandardPrice = value;
                OnPropertyChanged("EditProductVendor_StandardPrice");
            }
        }
        public decimal? EditProductVendor_LastReceiptCost
        {
            get
            {
                return this.ProductVendor_LastReceiptCost;
            }
            set
            {
                this.ProductVendor_LastReceiptCost = value;
                OnPropertyChanged("EditProductVendor_LastReceiptCost");
            }
        }
        public DateTime? EditProductVendor_LastReceiptDate
        {
            get
            {
                return this.ProductVendor_LastReceiptDate;
            }
            set
            {
                this.ProductVendor_LastReceiptDate = value;
                OnPropertyChanged("EditProductVendor_LastReceiptDate");
            }
        }
        public int EditProductVendor_MinOrderQty
        {
            get
            {
                return this.ProductVendor_MinOrderQty;
            }
            set
            {
                this.ProductVendor_MinOrderQty = value;
                OnPropertyChanged("EditProductVendor_MinOrderQty");
            }
        }
        public int EditProductVendor_MaxOrderQty
        {
            get
            {
                return this.ProductVendor_MaxOrderQty;
            }
            set
            {
                this.ProductVendor_MaxOrderQty = value;
                OnPropertyChanged("EditProductVendor_MaxOrderQty");
            }
        }
        public int? EditProductVendor_OnOrderQty
        {
            get
            {
                return this.ProductVendor_OnOrderQty;
            }
            set
            {
                this.ProductVendor_OnOrderQty = value;
                OnPropertyChanged("EditProductVendor_OnOrderQty");
            }
        }
        public string EditProductVendor_UnitMeasureCode
        {
            get
            {
                return this.ProductVendor_UnitMeasureCode;
            }
            set
            {
                this.ProductVendor_UnitMeasureCode = value;
                OnPropertyChanged("EditProductVendor_UnitMeasureCode");
            }
        }
        public DateTime EditProductVendor_ModifiedDate
        {
            get
            {
                return this.ProductVendor_ModifiedDate;
            }
            set
            {
                this.ProductVendor_ModifiedDate = value;
                OnPropertyChanged("EditProductVendor_ModifiedDate");
            }
        }

        public int ProductVendor_SelectedIndex
        {
            get
            {
                return ProductVendor_selectedIndex;
            }

            set
            {
                if (ProductVendor_selectedIndex == value)
                {
                    return;
                }
                ProductVendor_selectedIndex = value;

                OnPropertyChanged("ProductVendor_SelectedIndex");

                if (ProductVendor_selectedIndex >= 0)
                {
                    EditProductVendor_ProductID = ListProductVendor[ProductVendor_selectedIndex].ProductID;
                    EditProductVendor_BusinessEntityID = ListProductVendor[ProductVendor_selectedIndex].BusinessEntityID;
                    EditProductVendor_AverageLeadTime = ListProductVendor[ProductVendor_selectedIndex].AverageLeadTime;
                    EditProductVendor_StandardPrice = ListProductVendor[ProductVendor_selectedIndex].StandardPrice;
                    EditProductVendor_LastReceiptCost = ListProductVendor[ProductVendor_selectedIndex].LastReceiptCost;
                    EditProductVendor_LastReceiptDate = ListProductVendor[ProductVendor_selectedIndex].LastReceiptDate;
                    EditProductVendor_MinOrderQty = ListProductVendor[ProductVendor_selectedIndex].MinOrderQty;
                    EditProductVendor_MaxOrderQty = ListProductVendor[ProductVendor_selectedIndex].MaxOrderQty;
                    EditProductVendor_OnOrderQty = ListProductVendor[ProductVendor_selectedIndex].OnOrderQty;
                    EditProductVendor_UnitMeasureCode = ListProductVendor[ProductVendor_selectedIndex].UnitMeasureCode;
                    EditProductVendor_ModifiedDate = ListProductVendor[ProductVendor_selectedIndex].ModifiedDate;
                }
                else
                {
                    EditProductVendor_ProductID = 0;
                    EditProductVendor_BusinessEntityID = 0;
                    EditProductVendor_AverageLeadTime = 0;
                    EditProductVendor_StandardPrice = 0;
                    EditProductVendor_LastReceiptCost = 0;
                    EditProductVendor_LastReceiptDate = default(DateTime);
                    EditProductVendor_MinOrderQty = 0;
                    EditProductVendor_MaxOrderQty = 0;
                    EditProductVendor_OnOrderQty = 0;
                    EditProductVendor_UnitMeasureCode = "";
                    EditProductVendor_ModifiedDate = default(DateTime);
                }
            }
        }

        public ICommand EditClick_ProductVendor
        {
            get
            {
                return new Command(EditAndSave_ProductVendor);
            }
        }
        private void EditAndSave_ProductVendor()
        {
            if (ProductVendor_selectedIndex >= 0)
            {
                int numberOfChange = listProductVendor[ProductVendor_selectedIndex].ProductID;
                listProductVendor[ProductVendor_selectedIndex].ProductID = EditProductVendor_ProductID;
                listProductVendor[ProductVendor_selectedIndex].BusinessEntityID = EditProductVendor_BusinessEntityID;
                listProductVendor[ProductVendor_selectedIndex].AverageLeadTime = EditProductVendor_AverageLeadTime;
                listProductVendor[ProductVendor_selectedIndex].LastReceiptCost = EditProductVendor_LastReceiptCost;
                listProductVendor[ProductVendor_selectedIndex].LastReceiptDate = EditProductVendor_LastReceiptDate;
                listProductVendor[ProductVendor_selectedIndex].MinOrderQty = EditProductVendor_MinOrderQty;
                listProductVendor[ProductVendor_selectedIndex].MaxOrderQty = EditProductVendor_MaxOrderQty;
                listProductVendor[ProductVendor_selectedIndex].OnOrderQty = EditProductVendor_OnOrderQty;
                listProductVendor[ProductVendor_selectedIndex].UnitMeasureCode = EditProductVendor_UnitMeasureCode;
                listProductVendor[ProductVendor_selectedIndex].ModifiedDate = EditProductVendor_ModifiedDate;

                CollectionViewSource.GetDefaultView(listProductVendor).Refresh();

                foreach (ProductVendor pv in aw.ProductVendors)
                {
                    if (pv.BusinessEntityID == numberOfChange)
                    {
                        pv.ProductID = EditProductVendor_ProductID;
                        pv.BusinessEntityID = EditProductVendor_BusinessEntityID;
                        pv.AverageLeadTime = EditProductVendor_AverageLeadTime;
                        pv.LastReceiptCost = EditProductVendor_LastReceiptCost;
                        pv.LastReceiptDate = EditProductVendor_LastReceiptDate;
                        pv.MinOrderQty = EditProductVendor_MinOrderQty;
                        pv.MaxOrderQty = EditProductVendor_MaxOrderQty;
                        pv.OnOrderQty = EditProductVendor_OnOrderQty;
                        pv.UnitMeasureCode = EditProductVendor_UnitMeasureCode;
                        pv.ModifiedDate = EditProductVendor_ModifiedDate;
                    }
                }
                aw.SubmitChanges();
            }
        }

        #endregion
    }
}
