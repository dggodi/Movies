export function configure(aurelia) {

    aurelia.use
        .standardConfiguration()
        .developmentLogging()
        .plugin("./resources/index");

    //client side router
    aurelia.start().then(a => a.setRoot());

};