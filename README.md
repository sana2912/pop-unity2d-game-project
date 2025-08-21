# POP Assets-Only Backup

นี่คือ **Assets-only backup ของโปรเจกต์เกม POP  
ไม่ได้รวม ProjectSettings, Packages หรือ UserSettings และไม่ได้ใช้เพื่อรัน/อัปเดต project

## ทำไว้เพื่อ
- เก็บสำรองสิ่งที่เราสร้างเองทั้งหมด เช่น ภาพ, sprite, sound, animation, prefab, และ script
- เป็น port เฉย ๆ สำหรับดู asset / อ้างอิง / backup
- ไม่ได้ทำไว้เพื่อเปิด project บน Unity ใหม่ เพราะโปรเจกต์นี้สร้างบน **Unity 2021** และอาจเกิด error ถ้าเปิดบนเวอร์ชันใหม่

## มีแค่
- โฟลเดอร์ `Assets/` ทั้งหมด
  - Animation, Prefab, Script
  - ภาพ 2D, icon, sprite
  - เสียง (sound) ที่ตัดเอง
- **.gitignore** ที่กรอง Library, Logs, Packages, ProjectSettings, UserSettings และไฟล์ temporary อื่น ๆ

## ไม่มี (ไม่สามารถ clone project ไปรันได้นะ)
- ProjectSettings/
- Packages/
- UserSettings/
- Library/ Logs/ obj/
- ไฟล์ IDE (เช่น *.csproj, *.sln, *.vsconfig)

## ลองเล่นเกม
ถ้าอยากลองเล่นเกมคลิก link นี้นะ 
[POP on itch.io](https://sone9.itch.io/pop) 🎮
---
