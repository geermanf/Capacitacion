function invokeLater(ar: any[], callback: (...args: any[]) => void) {
    /* ... Invoke callback with 'args' ... */

    callback(ar);

}

// Unsound - invokeLater "might" provide any number of arguments
invokeLater([[2, 4],[2,3]], (x, y) => console.log(x + ", " + y));

// Confusing (x and y are actually required) and undiscoverable
invokeLater([3, 2], (x?, y?) => console.log(x + ", " + y));