class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        formatteds = s.strip().lower()
        formattedt = t.strip().lower()
        copies = 0

        if len(formatteds) != len(formattedt):
            return False

        for chars in formatteds:
            if formatteds.count(chars) != formattedt.count(chars):
                return False
        return True
    

    

        