var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/Home/get' },
        "columns": [
            { data: 'nm_pbm', "width": "25%" },
            { data: 'nama', "width": "15%" },
            { data: 'jumlah', "width": "10%" },
        ]
    });
}
