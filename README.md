# PostItNoteFront 簡易的Vue便利貼專案(API)   

## 創立緣由:
  過往的工作主要使用.net Core來開發專案，在需求不斷變更的情況下前端樣式會越來越複雜，提高維護難度。
  希望透過學習前端框架來因應不斷變更的需求與改善維護不易的狀況，為此第一個前端專案決定採用Vue來設計單頁應用程式，
  搭配.net Core 8 設計的Web API來建立前後分離的專案。   

## 專案說明
  本專案採用.net core 8 開發，資料庫使用SQL SERVER，使用Dapper與資料庫連線，以下簡易介紹API功能   
  
  **1. GET**   
  api/PostIt/Get 回傳所有狀態為有效的便利貼   
  api/PostIt/AllDeletePost 回傳所有已刪除的便利貼   
  api/PostIt/Get/{id} 回傳特定id的便利貼

  **2. POST**   
  /api/PostIt/Post 負責新增便利貼

  **3. PUT**   
  /api/PostIt/Put/{id} 編輯特定id的便利貼
 
  **4. Delete**   
 /api/PostIt/Delete/{id} 刪除特定id的便利貼    

   ## 展示影片
  [https://youtu.be/TY4g_hepVYs](https://youtu.be/TY4g_hepVYs)   

 ## 前端部分   
 [https://github.com/BillWang99/PostItNoteFront.git](https://github.com/BillWang99/PostItNoteFront.git)
