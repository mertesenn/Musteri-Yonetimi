# Musteri-Yonetimi
Sturbucks ve Portal kahve firmaları için müşteri yönetimi yapan bir sistem.

- Sturbucks ve Portal kahve firmaları için müşteri yönetimi yapan bir sistem.
- Iki firma da müşterilerini veritabanına kaydetmek istiyor.
- Sturbucks müsterilerini veritabanına kaydederken mutlaka mernis doğrulaması istiyor, ama Portal firması istemiyor

Proje esnek yapıdadır. Çünkü ileride belki Portal firması da müşteri kayıt sırasında kimlik kontrolü yapmak isteyebilir.
Burada interface ve abstract kullanılarak mvc modeline uygun, kalıtım alma işlemleri yapılarak proje geliştirilmiştir

Mernis dogrulama web servis adresi aşağıdaki gibidir;
https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?wsdl.
