;Daniel Gherghel

For Each Cab Assembly

If cngName == null then
	cngName<bool> = False
	cngName<style> = 1
	cngName<desc> = '2. Update name for the fillers'
End If

If fsfWidth == null then
	fsfWidth<bool> = False
	fsfWidth<style> = 1
	fsfWidth<desc> = '3. FSF width'
	fsfWidth<meas> = '<lst> 2.5 =2.5 | 3.5= 3.5 | 4.5= 4.5 | 5.5= 5.5'
End If

; UPDATED 08/22/23 - DANIEL G. - ADDED THE BASE AS WELL
If (Cab.Class = ASM_CLASS_UPPER OR Cab.Class = ASM_CLASS_BASE OR Cab.Class = ASM_CLASS_VANITY) and Cab.Type = ASM_TYPE_FILLER Then
	If cngName == True Then
		If DESC == 'FSF' Then
			NAME = 'FSF{Cab.DY}-{fsfWidth<meas>}'
		Else
			delete fsfWidth
		End If
	Else
		
		delete fsfWidth
		Exit
	End if
Else
	delete fsfWidth
	delete cngName
End If