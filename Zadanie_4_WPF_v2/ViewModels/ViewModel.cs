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

        #endregion

        #region PurchaseOrderHeader

        private int POH_PurchaseOrderID;
        private byte POH_RevisionNumber;
        private byte POH_Status;
        private int POH_EmployeeID;
        private int POH_VendorID;
        private int POH_ShipMethodID;
        private DateTime POH_OrderDate;
        private DateTime? POH_ShipDate;
        private decimal POH_SubTotal;
        private decimal POH_TaxAmt;
        private decimal POH_Freight;
        private decimal POH_TotalDue;
        private DateTime POH_ModifiedDate;
        private int POH_selectedIndex = 0;

        public int EditPOH_PurchaseOrderID
        {
            get
            {
                return this.POH_PurchaseOrderID;
            }
            set
            {
                this.POH_PurchaseOrderID = value;
                OnPropertyChanged("EditPOH_PurchaseOrderID");
            }
        }
        public byte EditPOH_RevisionNumber
        {
            get
            {
                return this.POH_RevisionNumber;
            }
            set
            {
                this.POH_RevisionNumber = value;
                OnPropertyChanged("EditPOH_RevisionNumber");
            }
        }
        public byte EditPOH_Status
        {
            get
            {
                return this.POH_Status;
            }
            set
            {
                this.POH_Status = value;
                OnPropertyChanged("EditPOH_Status");
            }
        }
        public int EditPOH_EmployeeID
        {
            get
            {
                return this.POH_EmployeeID;
            }
            set
            {
                this.POH_EmployeeID = value;
                OnPropertyChanged("EditPOH_EmployeeID");
            }
        }
        public int EditPOH_VendorID
        {
            get
            {
                return this.POH_VendorID;
            }
            set
            {
                this.POH_VendorID = value;
                OnPropertyChanged("EditPOH_VendorID");
            }
        }
        public int EditPOH_ShipMethodID
        {
            get
            {
                return this.POH_ShipMethodID;
            }
            set
            {
                this.POH_ShipMethodID = value;
                OnPropertyChanged("EditPOH_ShipMethodID");
            }
        }
        public DateTime EditPOH_OrderDate
        {
            get
            {
                return this.POH_OrderDate;
            }
            set
            {
                this.POH_OrderDate = value;
                OnPropertyChanged("EditPOH_OrderDate");
            }
        }
        public DateTime? EditPOH_ShipDate
        {
            get
            {
                return this.POH_ShipDate;
            }
            set
            {
                this.POH_ShipDate = value;
                OnPropertyChanged("EditPOH_ShipDate");
            }
        }
        public decimal EditPOH_SubTotal
        {
            get
            {
                return this.POH_SubTotal;
            }
            set
            {
                this.POH_SubTotal = value;
                OnPropertyChanged("EditPOH_SubTotal");
            }
        }
        public decimal EditPOH_TaxAmt
        {
            get
            {
                return this.POH_TaxAmt;
            }
            set
            {
                this.POH_TaxAmt = value;
                OnPropertyChanged("EditPOH_TaxAmt");
            }
        }
        public decimal EditPOH_Freight
        {
            get
            {
                return this.POH_Freight;
            }
            set
            {
                this.POH_Freight = value;
                OnPropertyChanged("EditPOH_Freight");
            }
        }
        public decimal EditPOH_TotalDue
        {
            get
            {
                return this.POH_TotalDue;
            }
            set
            {
                this.POH_TotalDue = value;
                OnPropertyChanged("EditPOH_TotalDue");
            }
        }
        public DateTime EditPOH_ModifiedDate
        {
            get
            {
                return this.POH_ModifiedDate;
            }
            set
            {
                this.POH_ModifiedDate = value;
                OnPropertyChanged("EditPOH_ModifiedDate");
            }
        }
        public int POH_SelectedIndex
        {
            get
            {
                return POH_selectedIndex;
            }

            set
            {
                if (POH_selectedIndex == value)
                {
                    return;
                }
                POH_selectedIndex = value;

                OnPropertyChanged("POH_selectedIndex");

                if (POH_selectedIndex >= 0)
                {
                    EditPOH_PurchaseOrderID = listPurchaseOrderHeader[POH_selectedIndex].PurchaseOrderID;
                    EditPOH_RevisionNumber = listPurchaseOrderHeader[POH_selectedIndex].RevisionNumber;
                    EditPOH_Status = listPurchaseOrderHeader[POH_selectedIndex].Status;
                    EditPOH_EmployeeID = listPurchaseOrderHeader[POH_selectedIndex].EmployeeID;
                    EditPOH_VendorID = listPurchaseOrderHeader[POH_selectedIndex].VendorID;
                    EditPOH_ShipMethodID = listPurchaseOrderHeader[POH_selectedIndex].ShipMethodID;
                    EditPOH_OrderDate = listPurchaseOrderHeader[POH_selectedIndex].OrderDate;
                    EditPOH_ShipDate = listPurchaseOrderHeader[POH_selectedIndex].ShipDate;
                    EditPOH_SubTotal = listPurchaseOrderHeader[POH_selectedIndex].SubTotal;
                    EditPOH_TaxAmt = listPurchaseOrderHeader[POH_selectedIndex].TaxAmt;
                    EditPOH_Freight = listPurchaseOrderHeader[POH_selectedIndex].Freight;
                    EditPOH_TotalDue = listPurchaseOrderHeader[POH_selectedIndex].TotalDue;
                    EditPOD_ModifiedDate = listPurchaseOrderHeader[POH_selectedIndex].ModifiedDate;
                }
                else
                {
                    EditPOH_PurchaseOrderID = 0;
                    EditPOH_RevisionNumber = 0;
                    EditPOH_Status = 0;
                    EditPOH_EmployeeID = 0;
                    EditPOH_VendorID = 0;
                    EditPOH_ShipMethodID = 0;
                    EditPOH_OrderDate = default(DateTime);
                    EditPOH_ShipDate = default(DateTime);
                    EditPOH_SubTotal = 0;
                    EditPOH_TaxAmt = 0;
                    EditPOH_Freight = 0;
                    EditPOH_TotalDue = 0;
                    EditPOD_ModifiedDate = default(DateTime);
                }
            }
        }

        public ICommand EditClick_POH
        {
            get
            {
                return new Command(EditAndSave_POH);
            }
        }
        private void EditAndSave_POH()
        {
            if (POH_selectedIndex >= 0)
            {
                int numberOfChange = listPurchaseOrderHeader[POH_selectedIndex].PurchaseOrderID;
                listPurchaseOrderHeader[POH_selectedIndex].PurchaseOrderID = EditPOH_PurchaseOrderID;
                listPurchaseOrderHeader[POH_selectedIndex].RevisionNumber = EditPOH_RevisionNumber;
                listPurchaseOrderHeader[POH_selectedIndex].Status = EditPOH_Status;
                listPurchaseOrderHeader[POH_selectedIndex].EmployeeID = EditPOH_EmployeeID;
                listPurchaseOrderHeader[POH_selectedIndex].VendorID = EditPOH_VendorID;
                listPurchaseOrderHeader[POH_selectedIndex].ShipMethodID = EditPOH_ShipMethodID;
                listPurchaseOrderHeader[POH_selectedIndex].OrderDate = EditPOH_OrderDate;
                listPurchaseOrderHeader[POH_selectedIndex].ShipDate = EditPOH_ShipDate;
                listPurchaseOrderHeader[POH_selectedIndex].SubTotal = EditPOH_SubTotal;
                listPurchaseOrderHeader[POH_selectedIndex].TaxAmt = EditPOH_TaxAmt;
                listPurchaseOrderHeader[POH_selectedIndex].Freight = EditPOH_Freight;
                listPurchaseOrderHeader[POH_selectedIndex].TotalDue = EditPOH_TotalDue;
                listPurchaseOrderHeader[POH_selectedIndex].ModifiedDate = EditPOH_ModifiedDate;

                CollectionViewSource.GetDefaultView(listPurchaseOrderHeader).Refresh();

                foreach (PurchaseOrderHeader poh in aw.PurchaseOrderHeaders)
                {
                    if (poh.PurchaseOrderID == numberOfChange)
                    {
                        poh.PurchaseOrderID = EditPOH_PurchaseOrderID;
                        poh.RevisionNumber = EditPOH_RevisionNumber;
                        poh.Status = EditPOH_Status;
                        poh.EmployeeID = EditPOH_EmployeeID;
                        poh.VendorID = EditPOH_VendorID;
                        poh.ShipMethodID = EditPOH_ShipMethodID;
                        poh.OrderDate = EditPOH_OrderDate;
                        poh.ShipDate = EditPOH_ShipDate;
                        poh.SubTotal = EditPOH_SubTotal;
                        poh.TaxAmt = EditPOH_TaxAmt;
                        poh.Freight = EditPOH_Freight;
                        poh.TotalDue = EditPOH_TotalDue;
                        poh.ModifiedDate = EditPOH_ModifiedDate;
                    }
                }
                aw.SubmitChanges();
            }
        }

        #endregion

        #region ShipMethod

        private int ShipMethod_ShipMethodID;
        private string ShipMethod_Name;
        private decimal ShipMethod_ShipBase;
        private decimal ShipMethod_ShipRate;
        private Guid ShipMethod_rowguid;
        private DateTime ShipMethod_ModifiedDate;
        private int ShipMethod_selectedIndex = 0;

        public int EditShipMethod_ShipMethodID
        {
            get
            {
                return this.ShipMethod_ShipMethodID;
            }
            set
            {
                this.ShipMethod_ShipMethodID = value;
                OnPropertyChanged("EditShipMethod_ShipMethodID");
            }
        }
        public string EditShipMethod_Name
        {
            get
            {
                return this.ShipMethod_Name;
            }
            set
            {
                this.ShipMethod_Name = value;
                OnPropertyChanged("EditShipMethod_Name");
            }
        }
        public decimal EditShipMethod_ShipBase
        {
            get
            {
                return this.ShipMethod_ShipBase;
            }
            set
            {
                this.ShipMethod_ShipBase = value;
                OnPropertyChanged("EditShipMethod_ShipBase");
            }
        }
        public decimal EditShipMethod_ShipRate
        {
            get
            {
                return this.ShipMethod_ShipRate;
            }
            set
            {
                this.ShipMethod_ShipRate = value;
                OnPropertyChanged("EditShipMethod_ShipRate");
            }
        }
        public Guid EditShipMethod_rowguid
        {
            get
            {
                return this.ShipMethod_rowguid;
            }
            set
            {
                this.ShipMethod_rowguid = value;
                OnPropertyChanged("EditShipMethod_rowguid");
            }
        }
        public DateTime EditShipMethod_ModifiedDate
        {
            get
            {
                return this.ShipMethod_ModifiedDate;
            }
            set
            {
                this.ShipMethod_ModifiedDate = value;
                OnPropertyChanged("EditShipMethod_ModifiedDate");
            }
        }
        public int ShipMethod_SelectedIndex
        {
            get
            {
                return ShipMethod_selectedIndex;
            }

            set
            {
                if (ShipMethod_selectedIndex == value)
                {
                    return;
                }
                ShipMethod_selectedIndex = value;

                OnPropertyChanged("ShipMethod_selectedIndex");

                if (ShipMethod_selectedIndex >= 0)
                {
                    EditShipMethod_ShipMethodID = listShipMethod[ShipMethod_selectedIndex].ShipMethodID;
                    EditShipMethod_Name = listShipMethod[ShipMethod_selectedIndex].Name;
                    EditShipMethod_ShipBase = listShipMethod[ShipMethod_selectedIndex].ShipBase;
                    EditShipMethod_ShipRate = listShipMethod[ShipMethod_selectedIndex].ShipRate;
                    EditShipMethod_rowguid = listShipMethod[ShipMethod_selectedIndex].rowguid;
                    EditShipMethod_ModifiedDate = listShipMethod[ShipMethod_selectedIndex].ModifiedDate;
                }
                else
                {
                    EditShipMethod_ShipMethodID = 0;
                    EditShipMethod_Name = "";
                    EditShipMethod_ShipBase = 0;
                    EditShipMethod_ShipRate = 0;
                    EditShipMethod_rowguid = default(Guid);
                    EditShipMethod_ModifiedDate = default(DateTime);
                }

            }
        }

        public ICommand EditClick_ShipMethod
        {
            get
            {
                return new Command(EditAndSave_ShipMethod);
            }
        }
        private void EditAndSave_ShipMethod()
        {
            if (ShipMethod_selectedIndex >= 0)
            {
                int numberOfChange = listShipMethod[ShipMethod_selectedIndex].ShipMethodID;
                listShipMethod[ShipMethod_selectedIndex].ShipMethodID = EditShipMethod_ShipMethodID;
                listShipMethod[ShipMethod_selectedIndex].Name = EditShipMethod_Name;
                listShipMethod[ShipMethod_selectedIndex].ShipBase = EditShipMethod_ShipBase;
                listShipMethod[ShipMethod_selectedIndex].ShipRate = EditShipMethod_ShipRate;
                listShipMethod[ShipMethod_selectedIndex].rowguid = EditShipMethod_rowguid;
                listShipMethod[ShipMethod_selectedIndex].ModifiedDate = EditShipMethod_ModifiedDate;
                CollectionViewSource.GetDefaultView(listShipMethod).Refresh();

                foreach (ShipMethod smh in aw.ShipMethods)
                {
                    if (smh.ShipMethodID == numberOfChange)
                    {
                        smh.ShipMethodID = EditShipMethod_ShipMethodID;
                        smh.Name = EditShipMethod_Name;
                        smh.ShipBase = EditShipMethod_ShipBase;
                        smh.ShipRate = EditShipMethod_ShipRate;
                        smh.rowguid = EditShipMethod_rowguid;
                        smh.ModifiedDate = EditShipMethod_ModifiedDate;
                    }
                }
                aw.SubmitChanges();
            }
        }

        #endregion

        #region Vendor

        private int Vendor_BusinessEntityID;
        private string Vendor_AccountNumber;
        private string Vendor_Name;
        private byte Vendor_CreditRating;
        private bool Vendor_PreferredVendorStatus;
        private bool Vendor_ActiveFlag;
        private string Vendor_PurchasingWebServiceURL;
        private DateTime Vendor_ModifiedDate;
        private int Vendor_selectedIndex = 0;

        public int EditVendor_BusinessEntityID
        {
            get
            {
                return this.Vendor_BusinessEntityID;
            }
            set
            {
                this.Vendor_BusinessEntityID = value;
                OnPropertyChanged("EditVendor_BusinessEntityID");
            }
        }
        public string EditVendor_AccountNumber
        {
            get
            {
                return this.Vendor_AccountNumber;
            }
            set
            {
                this.Vendor_AccountNumber = value;
                OnPropertyChanged("EditVendor_AccountNumber");
            }
        }
        public string EditVendor_Name
        {
            get
            {
                return this.Vendor_Name;
            }
            set
            {
                this.Vendor_Name = value;
                OnPropertyChanged("EditVendor_Name");
            }
        }
        public byte EditVendor_CreditRating
        {
            get
            {
                return this.Vendor_CreditRating;
            }
            set
            {
                this.Vendor_CreditRating = value;
                OnPropertyChanged("EditVendor_CreditRating");
            }
        }
        public bool EditVendor_PreferredVendorStatus
        {
            get
            {
                return this.Vendor_PreferredVendorStatus;
            }
            set
            {
                this.Vendor_PreferredVendorStatus = value;
                OnPropertyChanged("EditVendor_PreferredVendorStatus ");
            }
        }
        public bool EditVendor_ActiveFlag
        {
            get
            {
                return this.Vendor_ActiveFlag;
            }
            set
            {
                this.Vendor_ActiveFlag = value;
                OnPropertyChanged("EditVendor_ActiveFlag ");
            }
        }
        public string EditVendor_PurchasingWebServiceURL
        {
            get
            {
                return this.Vendor_PurchasingWebServiceURL;
            }
            set
            {
                this.Vendor_PurchasingWebServiceURL = value;
                OnPropertyChanged("EditVendor_PurchasingWebServiceURL ");
            }
        }
        public DateTime EditVendor_ModifiedDate
        {
            get
            {
                return this.Vendor_ModifiedDate;
            }
            set
            {
                this.Vendor_ModifiedDate = value;
                OnPropertyChanged("EditVendor_ModifiedDate");
            }
        }
        public int Vendor_SelectedIndex
        {
            get
            {
                return Vendor_selectedIndex;
            }

            set
            {
                if (Vendor_selectedIndex == value)
                {
                    return;
                }
                Vendor_selectedIndex = value;

                OnPropertyChanged("Vendor_selectedIndex");

                if (Vendor_selectedIndex >= 0)
                {
                    EditVendor_BusinessEntityID = listVendor[Vendor_selectedIndex].BusinessEntityID;
                    EditVendor_AccountNumber = listVendor[Vendor_selectedIndex].AccountNumber;
                    EditVendor_Name = listVendor[Vendor_selectedIndex].Name;
                    EditVendor_CreditRating = listVendor[Vendor_selectedIndex].CreditRating;
                    EditVendor_PreferredVendorStatus = listVendor[Vendor_selectedIndex].PreferredVendorStatus;
                    EditVendor_ActiveFlag = listVendor[Vendor_selectedIndex].ActiveFlag;
                    EditVendor_PurchasingWebServiceURL = listVendor[Vendor_selectedIndex].PurchasingWebServiceURL;
                    EditVendor_ModifiedDate = listVendor[Vendor_selectedIndex].ModifiedDate;
                }
                else
                {
                    EditVendor_BusinessEntityID = 0;
                    EditVendor_AccountNumber = "";
                    EditVendor_Name = "";
                    EditVendor_CreditRating = 0;
                    EditVendor_PreferredVendorStatus = true;
                    EditVendor_ActiveFlag = true;
                    EditVendor_PurchasingWebServiceURL = "";
                    EditVendor_ModifiedDate = default(DateTime);
                }
            }
        }

        public ICommand EditClick_Vendor
        {
            get
            {
                return new Command(EditAndSave_Vendor);
            }
        }
        private void EditAndSave_Vendor()
        {
            if (Vendor_selectedIndex >= 0)
            {
                int numberOfChange = listVendor[Vendor_selectedIndex].BusinessEntityID;
                listVendor[Vendor_selectedIndex].BusinessEntityID = EditVendor_BusinessEntityID;
                listVendor[Vendor_selectedIndex].AccountNumber = EditVendor_AccountNumber;
                listVendor[Vendor_selectedIndex].Name = EditVendor_Name;
                listVendor[Vendor_selectedIndex].CreditRating = EditVendor_CreditRating;
                listVendor[Vendor_selectedIndex].PreferredVendorStatus = EditVendor_PreferredVendorStatus;
                listVendor[Vendor_selectedIndex].ActiveFlag = EditVendor_ActiveFlag;
                listVendor[Vendor_selectedIndex].PurchasingWebServiceURL = EditVendor_PurchasingWebServiceURL;
                listVendor[Vendor_selectedIndex].ModifiedDate = EditVendor_ModifiedDate;

                CollectionViewSource.GetDefaultView(listVendor).Refresh();

                foreach (Vendor v in aw.Vendors)
                {
                    if (v.BusinessEntityID == numberOfChange)
                    {
                        v.BusinessEntityID = EditVendor_BusinessEntityID;
                        v.AccountNumber = EditVendor_AccountNumber;
                        v.Name = EditVendor_Name;
                        v.CreditRating = EditVendor_CreditRating;
                        v.PreferredVendorStatus = EditVendor_PreferredVendorStatus;
                        v.ActiveFlag = EditVendor_ActiveFlag;
                        v.PurchasingWebServiceURL = EditVendor_PurchasingWebServiceURL;
                        v.ModifiedDate = EditVendor_ModifiedDate;
                    }
                }
                aw.SubmitChanges();
            }
        }

        #endregion
    }
}
