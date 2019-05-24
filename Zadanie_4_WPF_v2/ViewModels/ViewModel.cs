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

        #region PurchaseOrderDetail

        private int POD_PurchaseOrderID;
        private int POD_PurchaseOrderDetailID;
        private DateTime POD_DueDate;
        private short POD_OrderQty;
        private int POD_ProductID;
        private decimal POD_UnitPrice;
        private decimal POD_LineTotal;
        private decimal POD_ReceivedQty;
        private decimal POD_RejectedQty;
        private decimal POD_StockedQty;
        private DateTime POD_ModifiedDate;
        private int POD_selectedIndex = 0;

        public int EditPOD_PurchaseOrderID
        {
            get
            {
                return this.POD_PurchaseOrderID;
            }
            set
            {
                this.POD_PurchaseOrderID = value;
                OnPropertyChanged("EditPOD_PurchaseOrderID");
            }
        }
        public int EditPOD_PurchaseOrderDetailID
        {
            get
            {
                return this.POD_PurchaseOrderDetailID;
            }
            set
            {
                this.POD_PurchaseOrderDetailID = value;
                OnPropertyChanged("EditPOD_PurchaseOrderDetailID");
            }
        }
        public DateTime EditPOD_DueDate
        {
            get
            {
                return this.POD_DueDate;
            }
            set
            {
                this.POD_DueDate = value;
                OnPropertyChanged("EditPOD_DueDate");
            }
        }
        public short EditPOD_OrderQty
        {
            get
            {
                return this.POD_OrderQty;
            }
            set
            {
                this.POD_OrderQty = value;
                OnPropertyChanged("EditPOD_OrderQty");
            }
        }
        public int EditPOD_ProductID
        {
            get
            {
                return this.POD_ProductID;
            }
            set
            {
                this.POD_ProductID = value;
                OnPropertyChanged("EditPOD_ProductID");
            }
        }
        public decimal EditPOD_UnitPrice
        {
            get
            {
                return this.POD_UnitPrice;
            }
            set
            {
                this.POD_UnitPrice = value;
                OnPropertyChanged("EditPOD_UnitPrice");
            }
        }
        public decimal EditPOD_LineTotal
        {
            get
            {
                return this.POD_LineTotal;
            }
            set
            {
                this.POD_LineTotal = value;
                OnPropertyChanged("EditPOD_LineTotal");
            }
        }
        public decimal EditPOD_ReceivedQty
        {
            get
            {
                return this.POD_ReceivedQty;
            }
            set
            {
                this.POD_ReceivedQty = value;
                OnPropertyChanged("EditPOD_ReceivedQty");
            }
        }
        public decimal EditPOD_RejectedQty
        {
            get
            {
                return this.POD_RejectedQty;
            }
            set
            {
                this.POD_RejectedQty = value;
                OnPropertyChanged("EditPOD_RejectedQty");
            }
        }
        public decimal EditPOD_StockedQty
        {
            get
            {
                return this.POD_StockedQty;
            }
            set
            {
                this.POD_StockedQty = value;
                OnPropertyChanged("EditPOD_StockedQty");
            }
        }
        public DateTime EditPOD_ModifiedDate
        {
            get
            {
                return this.POD_ModifiedDate;
            }
            set
            {
                this.POD_ModifiedDate = value;
                OnPropertyChanged("EditPOD_ModifiedDate");
            }
        }
        public int POD_SelectedIndex
        {
            get
            {
                return POD_selectedIndex;
            }

            set
            {
                if (POD_selectedIndex == value)
                {
                    return;
                }
                POD_selectedIndex = value;

                OnPropertyChanged("POD_selectedIndex");

                if (POD_selectedIndex >= 0)
                {
                    EditPOD_PurchaseOrderID = ListPurchaseOrderDetail[POD_selectedIndex].PurchaseOrderID;
                    EditPOD_PurchaseOrderDetailID = ListPurchaseOrderDetail[POD_selectedIndex].PurchaseOrderDetailID;
                    EditPOD_DueDate = ListPurchaseOrderDetail[POD_selectedIndex].DueDate;
                    EditPOD_OrderQty = ListPurchaseOrderDetail[POD_selectedIndex].OrderQty;
                    EditPOD_ProductID = ListPurchaseOrderDetail[POD_selectedIndex].ProductID;
                    EditPOD_UnitPrice = ListPurchaseOrderDetail[POD_selectedIndex].UnitPrice;
                    EditPOD_LineTotal = ListPurchaseOrderDetail[POD_selectedIndex].LineTotal;
                    EditPOD_ReceivedQty = ListPurchaseOrderDetail[POD_selectedIndex].ReceivedQty;
                    EditPOD_RejectedQty = ListPurchaseOrderDetail[POD_selectedIndex].RejectedQty;
                    EditPOD_StockedQty = ListPurchaseOrderDetail[POD_selectedIndex].StockedQty;
                    EditPOD_ModifiedDate = ListPurchaseOrderDetail[POD_selectedIndex].ModifiedDate;
                }
                else
                {
                    EditPOD_PurchaseOrderID = 0;
                    EditPOD_PurchaseOrderDetailID = 0;
                    EditPOD_DueDate = default(DateTime);
                    EditPOD_OrderQty = 0;
                    EditPOD_ProductID = 0;
                    EditPOD_UnitPrice = 0;
                    EditPOD_LineTotal = 0;
                    EditPOD_ReceivedQty = 0;
                    EditPOD_RejectedQty = 0;
                    EditPOD_StockedQty = 0;
                    EditPOD_ModifiedDate = default(DateTime);
                }
            }
        }

        public ICommand EditClick_POD
        {
            get
            {
                return new Command(EditAndSave_POD);
            }
        }
        private void EditAndSave_POD()
        {
            if (POD_selectedIndex >= 0)
            {
                int numberOfChange = listPurchaseOrderDetail[POD_selectedIndex].PurchaseOrderID;
                listPurchaseOrderDetail[POD_selectedIndex].PurchaseOrderID = EditPOD_PurchaseOrderID;
                listPurchaseOrderDetail[POD_selectedIndex].PurchaseOrderDetailID = EditPOD_PurchaseOrderDetailID;
                listPurchaseOrderDetail[POD_selectedIndex].DueDate = EditPOD_DueDate;
                listPurchaseOrderDetail[POD_selectedIndex].OrderQty = EditPOD_OrderQty;
                listPurchaseOrderDetail[POD_selectedIndex].ProductID = EditPOD_ProductID;
                listPurchaseOrderDetail[POD_selectedIndex].UnitPrice = EditPOD_UnitPrice;
                listPurchaseOrderDetail[POD_selectedIndex].LineTotal = EditPOD_LineTotal;
                listPurchaseOrderDetail[POD_selectedIndex].ReceivedQty = EditPOD_ReceivedQty;
                listPurchaseOrderDetail[POD_selectedIndex].RejectedQty = EditPOD_RejectedQty;
                listPurchaseOrderDetail[POD_selectedIndex].StockedQty = EditPOD_StockedQty;
                listPurchaseOrderDetail[POD_selectedIndex].ModifiedDate = EditPOD_ModifiedDate;

                CollectionViewSource.GetDefaultView(listPurchaseOrderDetail).Refresh();

                foreach (PurchaseOrderDetail pod in aw.PurchaseOrderDetails)
                {
                    if (pod.PurchaseOrderID == numberOfChange)
                    {
                        pod.PurchaseOrderID = EditPOD_PurchaseOrderID;
                        pod.PurchaseOrderDetailID = EditPOD_PurchaseOrderDetailID;
                        pod.DueDate = EditPOD_DueDate;
                        pod.OrderQty = EditPOD_OrderQty;
                        pod.ProductID = EditPOD_ProductID;
                        pod.UnitPrice = EditPOD_UnitPrice;
                        pod.LineTotal = EditPOD_LineTotal;
                        pod.ReceivedQty = EditPOD_ReceivedQty;
                        pod.RejectedQty = EditPOD_RejectedQty;
                        pod.StockedQty = EditPOD_StockedQty;
                        pod.ModifiedDate = EditPOD_ModifiedDate;
                    }
                }
                aw.SubmitChanges();
            }
        }

        #endregion
    }
}
