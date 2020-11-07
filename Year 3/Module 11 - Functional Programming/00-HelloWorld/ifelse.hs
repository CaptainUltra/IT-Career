simpleFunction a = 
    if a == 5
    then "It's five :)"
    else if a == 6 
        then "It's six :)"
        else "It's neither 5 nor 6 :("
main = do
    print(simpleFunction 12)