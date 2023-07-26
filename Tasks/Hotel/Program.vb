Imports System
Imports System.IO

Module Program
    Function HotelAbbreviation(ByVal hotel As String) As String
        Dim words() As String = hotel.Split(" "c)
        Dim abbreviation As String = String.Empty
        For Each word As String In words
            If word.Length > 0 Then
                abbreviation += word(0)
            End If
        Next
        abbreviation = abbreviation.ToUpper()
        Return abbreviation
    End Function
    Sub Main(args As String())
        Console.WriteLine("1. Dine In")
        Console.WriteLine("2. Takeaway")
        Console.WriteLine("Enter the user's choice: ")
        Dim choice As Integer = Convert.ToInt32(Console.ReadLine())
        Select Case choice
            Case 1
                Dim currentDate As Date = Date.Now
                Dim day As Integer = currentDate.Day
                Dim month As Integer = currentDate.Month
                Dim year As Integer = currentDate.Year
                Dim parent As String = "C:\{Path To Your Folder}\Hotel"
                Dim reference As String = Path.Combine(parent, year, month, day)
                Console.WriteLine("Enter the hotel/restuarant name: ")
                Dim hotel As String = Console.ReadLine()
                Dim type As String = "DINE"
                Dim abbreviation As String = HotelAbbreviation(hotel)
                Dim uniqueId As String = Guid.NewGuid().ToString("N").Substring(0, 6)
                Dim result As String = abbreviation + type + uniqueId
                Dim filename As String = result + ".txt"
                Dim fullpath As String = Path.Combine(reference, result)
                Directory.CreateDirectory(reference)
                'File.Create(fullpath)
                If Directory.Exists(reference) Then
                    Console.WriteLine("Directories Created Successfully")
                    If File.Exists(fullpath) Then
                        Console.WriteLine("File Already Exists")
                    Else
                        Console.WriteLine("File Does Not Exist")
                    End If
                Else
                    Console.WriteLine("Directories could not be created")
                End If
                Using writer As New StreamWriter(fullpath)
                    writer.WriteLine("Welcome to {0}", hotel)
                    writer.WriteLine("--------------------")
                    writer.WriteLine(result & "      " & Date.Now)
                    writer.WriteLine("--------------------")
                    writer.WriteLine("Item" & "  " & "Quantity" & "  " & "Price")
                    Dim pidli, nidli, tidli As Integer
                    Dim pdosa, ndosa, tdosa As Integer
                    Dim pvada, nvada, tvada As Integer
                    Dim puttapam, nuttapam, tuttapam As Integer
                    For i = 0 To 1 Step 0
                        Console.WriteLine("Do you want to dine? ")
                        Dim query As String = Console.ReadLine()
                        If query = "Y" Then
                            Console.WriteLine("What do you want to order today? ")
                            Console.WriteLine("1. Idli")
                            Console.WriteLine("2. Dosa")
                            Console.WriteLine("3. Vada")
                            Console.WriteLine("4. Uttapam")
                            Console.WriteLine("Enter the user's choice: ")
                            Dim ch As Integer = Convert.ToInt32(Console.ReadLine())
                            Select Case ch
                                Case 1
                                    Console.WriteLine("Enter the price of each idli: ")
                                    pidli = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of idlis to be ordered: ")
                                    nidli = Convert.ToInt32(Console.ReadLine())
                                    tidli = pidli * nidli
                                    writer.WriteLine("Idli" & "    " & nidli & "    " & tidli)
                                    Exit Select
                                Case 2
                                    Console.WriteLine("Enter the price of each dosa: ")
                                    pdosa = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of dosas to be ordered: ")
                                    ndosa = Convert.ToInt32(Console.ReadLine())
                                    tdosa = pdosa * ndosa
                                    writer.WriteLine("Dosa" & "    " & ndosa & "    " & tdosa)
                                    Exit Select
                                Case 3
                                    Console.WriteLine("Enter the price of each vada: ")
                                    pvada = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of vadas to be ordered: ")
                                    nvada = Convert.ToInt32(Console.ReadLine())
                                    tvada = pvada * nvada
                                    writer.WriteLine("Vada" & "    " & nvada & "    " & tvada)
                                    Exit Select
                                Case 4
                                    Console.WriteLine("Enter the price of each uttapam: ")
                                    puttapam = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of uttapams to be ordered: ")
                                    nuttapam = Convert.ToInt32(Console.ReadLine())
                                    tuttapam = puttapam * nuttapam
                                    writer.WriteLine("Uttapam" & "    " & nuttapam & "    " & tuttapam)
                                    Exit Select
                                Case Else
                                    Console.WriteLine("Not a valid choice")
                                    Exit Select
                            End Select
                        Else
                            Dim total As Integer = tidli + tdosa + tvada + tuttapam
                            writer.WriteLine("--------------------")
                            writer.WriteLine("Total: {0}", total)
                            writer.WriteLine("Thank you! visit again.")
                            Exit For
                        End If
                    Next
                End Using
            Case 2
                Dim currentDate As Date = Date.Now
                Dim day As Integer = currentDate.Day
                Dim month As Integer = currentDate.Month
                Dim year As Integer = currentDate.Year
                Dim parent As String = "C:\Users\mitra\Desktop\VB-NET-Programs\Hotel"
                Dim reference As String = Path.Combine(parent, year, month, day)
                Console.WriteLine("Enter the hotel/restuarant name: ")
                Dim hotel As String = Console.ReadLine()
                Dim type As String = "TAKE"
                Dim abbreviation As String = HotelAbbreviation(hotel)
                Dim uniqueId As String = Guid.NewGuid().ToString("N").Substring(0, 6)
                Dim result As String = abbreviation + type + uniqueId
                Dim filename As String = result + ".txt"
                Dim fullpath As String = Path.Combine(reference, result)
                Directory.CreateDirectory(reference)
                'File.Create(fullpath)
                If Directory.Exists(reference) Then
                    Console.WriteLine("Directories Created Successfully")
                    If File.Exists(fullpath) Then
                        Console.WriteLine("File Already Exists")
                    Else
                        Console.WriteLine("File Does Not Exist")
                    End If
                Else
                    Console.WriteLine("Directories could not be created")
                End If
                Using writer As New StreamWriter(fullpath)
                    writer.WriteLine("Welcome to {0}", hotel)
                    writer.WriteLine("--------------------")
                    writer.WriteLine(result & "      " & Date.Now)
                    writer.WriteLine("--------------------")
                    writer.WriteLine("Item" & "  " & "Quantity" & "  " & "Price")
                    Dim pidli, nidli, tidli As Integer
                    Dim pdosa, ndosa, tdosa As Integer
                    Dim pvada, nvada, tvada As Integer
                    Dim puttapam, nuttapam, tuttapam As Integer
                    For i = 0 To 1 Step 0
                        Console.WriteLine("Do you want to take away? ")
                        Dim query As String = Console.ReadLine()
                        If query = "Y" Then
                            Console.WriteLine("What do you want to order today? ")
                            Console.WriteLine("1. Idli")
                            Console.WriteLine("2. Dosa")
                            Console.WriteLine("3. Vada")
                            Console.WriteLine("4. Uttapam")
                            Console.WriteLine("Enter the user's choice: ")
                            Dim ch As Integer = Convert.ToInt32(Console.ReadLine())
                            Select Case ch
                                Case 1
                                    Console.WriteLine("Enter the price of each idli: ")
                                    pidli = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of idlis to be ordered: ")
                                    nidli = Convert.ToInt32(Console.ReadLine())
                                    tidli = pidli * nidli
                                    writer.WriteLine("Idli" & "    " & nidli & "    " & tidli)
                                    Exit Select
                                Case 2
                                    Console.WriteLine("Enter the price of each dosa: ")
                                    pdosa = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of dosas to be ordered: ")
                                    ndosa = Convert.ToInt32(Console.ReadLine())
                                    tdosa = pdosa * ndosa
                                    writer.WriteLine("Dosa" & "    " & ndosa & "    " & tdosa)
                                    Exit Select
                                Case 3
                                    Console.WriteLine("Enter the price of each vada: ")
                                    pvada = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of vadas to be ordered: ")
                                    nvada = Convert.ToInt32(Console.ReadLine())
                                    tvada = pvada * nvada
                                    writer.WriteLine("Vada" & "    " & nvada & "    " & tvada)
                                    Exit Select
                                Case 4
                                    Console.WriteLine("Enter the price of each uttapam: ")
                                    puttapam = Convert.ToInt32(Console.ReadLine())
                                    Console.WriteLine("Enter the number of uttapams to be ordered: ")
                                    nuttapam = Convert.ToInt32(Console.ReadLine())
                                    tuttapam = puttapam * nuttapam
                                    writer.WriteLine("Uttapam" & "    " & nuttapam & "    " & tuttapam)
                                    Exit Select
                                Case Else
                                    Console.WriteLine("Not a valid choice")
                                    Exit Select
                            End Select
                        Else
                            Dim total As Integer = tidli + tdosa + tvada + tuttapam
                            writer.WriteLine("--------------------")
                            writer.WriteLine("Total: {0}", total)
                            writer.WriteLine("Thank you! visit again.")
                            Exit For
                        End If
                    Next
                    Directory.CreateDirectory(reference)
                    'File.Create(fullpath)
                    If Directory.Exists(reference) Then
                        Console.WriteLine("Directories Created Successfully")
                        If File.Exists(fullpath) Then
                            Console.WriteLine("File Created Successfully")
                        Else
                            Console.WriteLine("File could not be created")
                        End If
                    Else
                        Console.WriteLine("Directories could not be created")
                    End If
                End Using
            Case Else
                Console.WriteLine("Not a valid choice")
        End Select
    End Sub
End Module
