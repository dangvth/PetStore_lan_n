var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinute').off('click').on('click', function () {
            window.location.href = "/";
        });
        $('#btnPayment').off('click').on('click', function () {
            window.location.href = "/payment";
        });
        $('#btnUpdate').off('click').on('click', function () {
            var listProduct = $('.txtQuantity');
            var cartList = [];
            $.each(listProduct, function (i, item) {
                cartList.push({
                    Quantity: $(item).val(),
                    PetFood: {
                        pf_id: $(item).data('id')
                    }
                });
            });

            $.ajax({
                url: '/cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/cart";
                    }
                }
            })
        });
        //$('.btn-delete').off('click').on('click', function (e) {
        //    e.prevenDefault();
        //    $.ajax({
        //        url: '/cart/Delete',
        //        data: { id: $(this).data('id') },
        //        dataType: 'json',
        //        type: 'POST',
        //        success: function (res) {
        //            if (res.status == true) {
        //                window.location.href = "/cart";
        //            }
        //        }
        //    });
        //});
    }
}
cart.init();