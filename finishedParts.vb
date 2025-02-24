;Modifies Parts names 
;Daniel Gherghel

 For Each AS|LU|RU|TO|DE|FT|BO|PT|UB Part



;if finished_cab == null then
	;finished_cab<bool> = False
	;finished_cab<style> = 1
	;finished_cab<desc> = 'Finished Cabinet Interior'
;end if

If fin_cab = 0 || fin_cab = 1 || finn_cab1 = 0 || finn_cab1 = 1 Then
	delete fin_cab
	delete finn_cab1
End If


if FININT == 1 and Name == 'AS' then ;adjustable shelf
	Name = 'Finished Adjustable'
else if FININT == 1 and Name == 'LU' then ; left end
	Name = 'Finished Left End'
else if FININT == 1 and Name == 'RU' then ; right end
	Name = 'Finished Right End'
else if FININT == 1 and Name == 'UB' then ; back
	Name = 'Finished Back'
else if FININT == 1 and Name == 'TO' then ; top
	Name = 'Finished Top'
else if FININT == 1 and Name == 'DE' then ; Deck
	Name = 'Finished Deck'
else if FININT == 1 and Name == 'BO' then ; Bottom
	Name = 'Finished Bottom'
else if FININT == 1 and Name == 'FT' then ; Front Toe
	Name = 'Finished Front Toe'
else if FININT == 1 and Name == 'PT' then ; Partition
	Name = 'Finished Partition'
end if
end if
end if
end if
end if
end if
end if
end if
end if
