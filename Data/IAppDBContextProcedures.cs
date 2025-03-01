﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using InventoryManagementSystem.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public partial interface IAppDBContextProcedures
    {
        Task<List<st_CheckProductExistResult>> st_CheckProductExistAsync(long? prodID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_deleteProductsAsync(long? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_deleteProductsFromPurchaseInvoiceDetailsAsync(long? purchaseinvoicedetailsID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_deleteSuppliersAsync(int? supp_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getCategoriesResult>> st_getCategoriesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getCategoriesListResult>> st_getCategoriesListAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getLastPurchaseInvoiceIdResult>> st_getLastPurchaseInvoiceIdAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductbyBarcodeResult>> st_getProductbyBarcodeAsync(string barcode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductIdwrtBarcodeFromProductPricesResult>> st_getProductIdwrtBarcodeFromProductPricesAsync(string barcode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductQuantityResult>> st_getProductQuantityAsync(long? prodID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductQuantityFromStockResult>> st_getProductQuantityFromStockAsync(long? prodID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductsbyBarcodeForPurchaseInvoicesResult>> st_getProductsbyBarcodeForPurchaseInvoicesAsync(string barcode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_GetProductStockwrtProductIDResult>> st_GetProductStockwrtProductIDAsync(long? prodID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductswrtCategoriesResult>> st_getProductswrtCategoriesAsync(int? categID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getProductwrtBarcodeForSaleResult>> st_getProductwrtBarcodeForSaleAsync(string barcode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getPurchaseInvoiceDetailsResult>> st_getPurchaseInvoiceDetailsAsync(long? purchaseinvoiceID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getPurchaseInvoiceListResult>> st_getPurchaseInvoiceListAsync(int? month, int? year, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getSalesIDResult>> st_getSalesIDAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getStockResult>> st_getStockAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_getSuppliersResult>> st_getSuppliersAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertCategoriesAsync(string name, string isActive, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertProductPricesAsync(long? prodID, decimal? bp, decimal? sp, DateTime? buyingdate, decimal? profitper, decimal? discount, string productbarcode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertProductsAsync(string productname, string productbarcode, string productexpirydate, long? productcategoryID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertPurchaseInvoiceDetailsAsync(long? purchaseID, long? prodID, int? quant, decimal? total, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertPurchaseInvoicesAsync(DateTime? date, long? suppID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertSalesAsync(DateTime? date, double? totalamt, double? totaldisc, double? givenamt, double? @return, int? payType, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_insertSalesDetailsResult>> st_insertSalesDetailsAsync(long? saleID, long? prodID, int? quantity, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_insertStockResult>> st_insertStockAsync(long? prodID, int? quan, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_insertSuppliersAsync(string suppliername, string contactpersonname, string phone1, string phone2, string address, string ntn, bool? status, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_LoadListSuppliersResult>> st_LoadListSuppliersAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_searchCategoriesResult>> st_searchCategoriesAsync(string data, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_searchProductsResult>> st_searchProductsAsync(string data, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<st_searchSuppliersResult>> st_searchSuppliersAsync(string data, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_updateProductPricesAsync(decimal? sp, decimal? profitper, decimal? discount, long? prodID, decimal? productbuyingPrice, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_updateProductPriceswrtDateAsync(long? prodID, decimal? bp, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_updateProductsAsync(long? productid, string productname, string productbarcode, DateTime? productexpirydate, int? productcategoryID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_updateStocksAsync(long? prodID, int? quan, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> st_updateSuppliersAsync(string suppliername, string contactpersonname, string phone1, string phone2, string address, string ntn, bool? status, int? supp_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
