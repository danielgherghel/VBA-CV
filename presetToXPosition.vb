; DANIEL GHERGHEL 06/27/23
; SET THE BLIND CORNER CABINETS 3" FROM THE WALL - W/KILL SWITCH IN CASE IS REQUIRED

For Each CAB Assembly

  	If setXpos == null Then
  		setXpos<bool> = False
  		setXpos<style> = 1
  		setXpos<desc> = 'Update Corner Cabinet X Position'
  	End If
  	
	If x = -dx/2 Then
		Exit
	End If
	

;If Cab.Class = !ASM_CLASS_BASE or Cab.Class = !ASM_CLASS_UPPER Then
;	If Cab.Type = !ASM_TYPE_BLINDL or Cab.Type = !ASM_TYPE_BLINDR Then
;		delete setXpos
;	End If
;End If

; updated 01/10/24 DANIEL G.
If Cab.Type = !ASM_TYPE_BLINDL OR Cab.Type = !ASM_TYPE_BLINDR Then
	delete setXpos
End If

If Cab.Type == 6 Then
	delete setXpos
End If


	If setXpos == True Then
		Exit
	Else
		If Cab.Class = ASM_CLASS_BASE Then
			If Cab.Type = ASM_TYPE_BLINDL Then
				x = 3
				
			End If
		End If

		If Cab.Class = ASM_CLASS_BASE Then
			If Cab.Type = ASM_TYPE_BLINDR Then
				x = :DX - DX -3
				
		End If
		End If

		If Cab.Class = ASM_CLASS_UPPER Then
			If Cab.Type = ASM_TYPE_BLINDL Then
				x = 3
				
			End If
		End If

		If Cab.Class = ASM_CLASS_UPPER Then
			If Cab.Type = ASM_TYPE_BLINDR Then
				x = :DX - DX -3
				
		End If
	End If
	End If
