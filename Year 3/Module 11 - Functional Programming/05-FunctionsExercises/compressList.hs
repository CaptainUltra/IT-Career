func a b = 
    if a == (head b)
        then b
        else a:b
compress [] = []
compress x = foldr func [last x] x

main = do
    putStrLn(show(compress [1,1,1,1,1,1,1,1,1,1,1,1,2,3,4,5,5,7,8]))