import random

if __name__ == '__main__':
    gameArray = [random.randint(0, 7) for i in range(4)]
    #print(gameArray)
    inputArray = [None] * 4
    arrayMask = [None] * 4
    rawInput = ""
    rangeInput = range(0, 8)
    rangeFlag = False
    endFlag = False
    tries = 0

    print(
            "███╗   ███╗ █████╗ ███████╗████████╗███████╗██████╗ ███╗   ███╗██╗███╗   ██╗██████╗\n"
            "████╗ ████║██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗████╗ ████║██║████╗  ██║██╔══██╗\n"
            "██╔████╔██║███████║███████╗   ██║   █████╗  ██████╔╝██╔████╔██║██║██╔██╗ ██║██║  ██║\n"
            "██║╚██╔╝██║██╔══██║╚════██║   ██║   ██╔══╝  ██╔══██╗██║╚██╔╝██║██║██║╚██╗██║██║  ██║\n"
            "██║ ╚═╝ ██║██║  ██║███████║   ██║   ███████╗██║  ██║██║ ╚═╝ ██║██║██║ ╚████║██████╔╝\n"
            "╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝╚═════╝ \n")

    while tries < 8 and endFlag == False:
        while rawInput.isdecimal() == False or rangeFlag == False or len(rawInput) < 4:
            rawInput = input("Entrez votre réponse (4 chiffres entre 0 et 7) :\n")[0:4]
            for i, digit in enumerate(rawInput, start=0):
                if rawInput.isdecimal() == True:
                    if int(rawInput[i]) in rangeInput:
                        rangeFlag = True
                        inputArray[i] = int(rawInput[i])
                    else:
                        rangeFlag = False
            print("\n")
        tries += 1
        print("Essai #" + str(tries) + "\n")
        #print(inputArray)

        for i in range(4):
            if inputArray[i] == gameArray[i]:
                arrayMask[i] = True

        for i in range(4):
            if arrayMask[i] == None:
                for j in range(4):
                    if gameArray[i] == inputArray[j] and arrayMask[j] is not True:
                        arrayMask[i] = False

        #print(arrayMask)

        rawInput = ""
        for i in range(arrayMask.count(True)):
            rawInput += "*"
        for i in range(arrayMask.count(False)):
            rawInput += "o"

        print(rawInput)

        if arrayMask.count(True) == 4:
            print("Victoire !")
            endFlag = True
        elif tries == 8:
            print("Échec !\n"
                  "La réponse était " + ''.join(map(str,gameArray)) + "\n")
        else:
            arrayMask = [None] * 4
