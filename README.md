Encryption API
Ett smidigt API för kryptering och avkryptering, utvecklat för att hantera textomvandlingar via enkla URL-anrop. Applikationen är driftsatt på AWS Elastic Beanstalk.

📝 Sammanfattning
Tjänsten låter användare kryptera text genom att skicka meddelanden och en "shift"-parameter (förskjutning) direkt i webbadressen. Detta gör det enkelt att integrera i andra projekt eller testa direkt i webbläsaren.

Status: Live på AWS

Miljö: Elastic Beanstalk (eu-west-3)

Metod: GET-requests

🚀 Live Endpoint
Bas-URL: http://encryptionapp-env.eba-mwtiutss.eu-west-3.elasticbeanstalk.com

🛠 Så här testar du API:et
Du kan testa API:et direkt i din webbläsare genom att klicka på länkarna nedan eller skriva in dem i adressfältet.

1. Kryptera (Encrypt)
För att kryptera en text använder du /encrypt och anger text samt shift.

Format: /encrypt?text=[DIN_TEXT]&shift=[ANTAL_STEG]

Exempel: Testa att kryptera "test" med shift 1

2. Avkryptera (Decrypt)
För att avkryptera en text använder du /decrypt med den krypterade strängen.

Format: /decrypt?text=[KRYPTERAD_TEXT]&shift=[ANTAL_STEG]

Exempel: Testa att avkryptera "uftu" med shift 1