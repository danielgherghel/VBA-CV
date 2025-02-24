
;Modifies Object
;Daniel Gherghel 05/04/23
;updated by Daniel G. on 08/23/24 / Closet naming
; this code replaced a previous 10000 lines code developed by someone else
;  also simplifies how the user can alter the naming without compromising on the real cabinet sizes those being shown automatically based on the current size

For Each Cab Assembly

If Cab.Class = 21 Then ; 21 = Closet
		If Cab.Type = 39 Then
				Name = 'Vertical-{DY}x{DZ}'
			Else If Cab.TYPE = 40 Then
				Name = 'Horizontal-{DX}x{DZ}'
			Else 
				;Name = 'Closet Unit - {DX}x{DY}x{DZ}'
				If STYPE = 14 Then
					Name = 'Hanging Unit - {DX}x{DY}x{DZ}'
				Else 
					Name = 'Closet Unit - {DX}x{DY}x{DZ}'
					
				End If
		End If
		End If
	Exit
End If


If manualUpdateName == null Then
	manualUpdateName<bool> = False
	manualUpdateName<style> = 1
	manualUpdateName<desc> = 'Update Name Manually'
End If

newName = '{DX}x{DY}x{DZ}'

If manualUpdateName == True Then

	delete {uName}
	delete {uDesc}

Else
	If cab.face.dor_open.HNG==1 and cab.face.dor_open@2.HNG==2 Then
		Name = '{uName}-{newName}-{uDesc}'
	Else If Cab.Face.DOR_OPEN.HNG == 1 Then
		Name = '{uName}-{newName}-L-{uDesc}'
	Else If Cab.Face.DOR_OPEN.HNG == 2 Then
		Name = '{uName}-{newName}-R-{uDesc}'
	Else If Cab.Face.DOR_OPEN.HNG == 3 Then
		Name = '{uName}-{newName}-T-{uDesc}'
	Else If Cab.Face.DOR_OPEN.HNG == 4 Then
		Name = '{uName}-{newName}-B-{uDesc}'
	Else
		Name = '{uName}-{newName}-{uDesc}'

	End If
	End If
	End If
	End If
	End If



	;added
	If cab.TYPE == 6 || cab.TYPE == 7 || cab.TYPE == 8 || cab.TYPE == 9 Then
	exit
	Else
	If cab.ETL == 1 and cab.ETR == 1 Then
		Name = '{uName}-{newName}-{uDesc}-FEB'
		Else If cab.ETL == 1 Then
			Name = '{uName}-{newName}-{uDesc}-FEL'
		Else If cab.ETR == 1 Then
			Name = '{uName}-{newName}-{uDesc}-FER'
		End If
		End If

		End If
		
		
		
	End if
	;end of added
	



End If
