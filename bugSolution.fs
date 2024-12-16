let mutable x = 1
let y = ref x

let f () = 
    x <- 2
    y := x; //Update the reference to the new value
    !y

let z = f()
printf "%d %d" x z // prints 2 2