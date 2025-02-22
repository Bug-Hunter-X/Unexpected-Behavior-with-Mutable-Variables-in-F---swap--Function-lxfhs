let swap (x, y) =
    (y, x)

let mutable x = 10
let mutable y = 20

let (x, y) = swap (x, y)
printf "%d %d" x y //This will correctly print 20 10