a <- 42
A <- a * 2 # R is case sensitive
print(a)
cat(A, "\n") # "84" is concatenated with "\n"
if (A > a) # true, 84 > 42
    {
    cat(A, ">", a, "\n")
}

#I click R Tools session execute in interactive but
#i get the error: Warning message:
#In base::loadNamespace("rtvs", lib.loc = "c:\\program files (x86)\\microsoft visual studio\\2019\\community\\common7\\ide\\extensions\\3lb0souu.ufg"):
#package ‘rtvs’ has no 'package.rds' in Meta / so I do: save(an_object, file = "an_object.Rds")
#it doesn't help so i create package.rds file and copy it to 
#C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\3lb0souu.ufg'
#save(an_object, file = "an_object.Rds")
#it fixed the problem so now I get the result in r interactive:> if (A > a) # true, 84 > 42
#I create go.go file
