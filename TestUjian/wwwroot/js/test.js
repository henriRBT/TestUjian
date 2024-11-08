var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/Home/getall' },
        "columns": [
            { data: 'mbrg_kemasan', "width": "25%" },
            { data: 'kd_satuan', "width": "15%" },
            { data: 'jumlah', "width": "10%" },
        ]
    });
}
