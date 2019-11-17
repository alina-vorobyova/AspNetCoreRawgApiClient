let page;
let totalPages;
let url;

async function  initPagination(p, t, u) {
    page = p;
    totalPages = t;
    url = u;
    page++;

    if (page > totalPages)
        return;

    let response = await fetch(`${url}&page=${page}`);
    let html = await response.text();
    //console.log(html);
    $('#gameResults').append(html);
}


//$(window).scroll(async function () {
   
//    if ($(window).scrollTop() + $(window).height() > $(document).height() - 100) {
//        page++;

//        if (page > totalPages)
//            return;

//        let response = await fetch(`${url}&page=${page}`);
//        let html = await response.text();
//        //console.log(html);
//        $('#gameResults').append(html);
//    }
//});