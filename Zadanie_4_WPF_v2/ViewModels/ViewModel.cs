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
    }
}
