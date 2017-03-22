$(document).ready(function () {
    $('#myModal').on('show.bs.modal', function (e) {
        var stockId = $(e.relatedTarget).data('stock-id');
        $.get('/stock/' + stockId, function(data){
            $("#stockId").val(stockId);
            $("#StockName").val(data.stockName);
        });        
    });
});