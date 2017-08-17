function invokeLater(ar, callback) {
    /* ... Invoke callback with 'args' ... */
    callback(ar);
}
// Unsound - invokeLater "might" provide any number of arguments
invokeLater([2, 4, 1], function (x, y) { return console.log(x + ", " + y); });
// Confusing (x and y are actually required) and undiscoverable
invokeLater([3], function (x, y) { return console.log(x + ", " + y); });
