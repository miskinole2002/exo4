import requests
import json 
from gpiozero import Button,LED
    
res=requests.get("http://localhost:60320/Alarm/GetAllSystInfos")
#print(res.content)
Res=json.loads(res.text)
#print(Res)
#for i in Res:
    #print(i['Id'],i["Z1"],i["Z2"],i["Z3"],i["Z4"])

class pi:


    def act(self,State):

        
        if State==0 and self.CN0.is_pressed:
                 State=1
        elif State==1 and self.CN0.is_pressed:
                State=0

        return State

    def __init__(self ,CNO,CN1,CN2,CN3,CN4,Reset,led) :
        
        self.CN0=Button(CNO)
        self.CN1=Button(CN1)
        self.CN2=Button(CN2)
        self.CN3=Button(CN3)
        self.CN4=Button(CN4)
        self.Reset=Button(Reset)
        self.led=LED(led)
    
        def Init():
            msg={"Id":1,'Status':Status,'Z1':Z1,'Z2':Z2,'Z3':Z3,'Z4':Z4}
            State=Res[0]["Status"]
            Status=self.act(State)
                
            if Status==1:

                if self.CN0.is_pressed:
                    Z1="on"
                if self.CN1.is_pressed:
                     Z2="on"
                if self.CN0.is_pressed:
                     Z3="on"
                if self.CN1.is_pressed:
                     Z4="on"
            else :
                msg={"Id":1,'Status':Status,'Z1':'off','Z2':'off','Z3':'off','Z4':'off'}
                       
            res1=requests.get("http://localhost:60320/Alarm/UpdateStatePi",params=msg) 
              
 
        
 
