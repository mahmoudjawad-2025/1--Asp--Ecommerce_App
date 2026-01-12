---
title: PL | v1 v1.0.0
language_tabs:
  - "false": "false"
language_clients:
  - "false": ""
toc_footers: []
includes: []
search: false
highlight_theme: darkula
headingLevel: 2

---

<!-- Generator: Widdershins v4.0.1 -->

<h1 id="pl-v1">PL | v1 v1.0.0</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

Base URLs:

* <a href="https://localhost:7050">https://localhost:7050</a>

* <a href="http://localhost:5160">http://localhost:5160</a>

<h1 id="pl-v1-cart">Cart</h1>

## post__api_Customer_Cart

> Code samples

`POST /api/Customer/Cart`

> Body parameter

```json
{
  "productId": 0
}
```

<h3 id="post__api_customer_cart-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[CartRequest](#schemacartrequest)|true|none|

<h3 id="post__api_customer_cart-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Customer_Cart

> Code samples

`GET /api/Customer/Cart`

<h3 id="get__api_customer_cart-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-checkouts">CheckOuts</h1>

## post__api_customer_CheckOuts_payment

> Code samples

`POST /api/customer/CheckOuts/payment`

> Body parameter

```json
{
  "paymentMethod": "Cash"
}
```

<h3 id="post__api_customer_checkouts_payment-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[CheckOutRequest](#schemacheckoutrequest)|true|none|

<h3 id="post__api_customer_checkouts_payment-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_customer_CheckOuts_Success_{orderId}

> Code samples

`GET /api/customer/CheckOuts/Success/{orderId}`

<h3 id="get__api_customer_checkouts_success_{orderid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|orderId|path|integer(int32)|true|none|

<h3 id="get__api_customer_checkouts_success_{orderid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-reviews">Reviews</h1>

## post__api_customer_Reviews

> Code samples

`POST /api/customer/Reviews`

> Body parameter

```json
{
  "productId": 0,
  "comment": "string",
  "rate": 0
}
```

<h3 id="post__api_customer_reviews-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ReviewRequest](#schemareviewrequest)|true|none|

<h3 id="post__api_customer_reviews-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-users">Users</h1>

## get__api_customer_Users

> Code samples

`GET /api/customer/Users`

<h3 id="get__api_customer_users-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_customer_Users_{id}

> Code samples

`GET /api/customer/Users/{id}`

<h3 id="get__api_customer_users_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|string|true|none|

<h3 id="get__api_customer_users_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_customer_Users_block_{userId}

> Code samples

`PATCH /api/customer/Users/block/{userId}`

> Body parameter

```json
0
```

<h3 id="patch__api_customer_users_block_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|
|body|body|integer(int32)|true|none|

<h3 id="patch__api_customer_users_block_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_customer_Users_unblock_{userId}

> Code samples

`PATCH /api/customer/Users/unblock/{userId}`

<h3 id="patch__api_customer_users_unblock_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|

<h3 id="patch__api_customer_users_unblock_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_customer_Users_isblock_{userId}

> Code samples

`PATCH /api/customer/Users/isblock/{userId}`

<h3 id="patch__api_customer_users_isblock_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|

<h3 id="patch__api_customer_users_isblock_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_customer_Users_changeRole_{userId}

> Code samples

`PATCH /api/customer/Users/changeRole/{userId}`

> Body parameter

```json
{
  "roleName": "string"
}
```

<h3 id="patch__api_customer_users_changerole_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|
|body|body|[ChangeRoleRequest](#schemachangerolerequest)|true|none|

<h3 id="patch__api_customer_users_changerole_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-orders">Orders</h1>

## get__api_Orders_status_{status}

> Code samples

`GET /api/Orders/status/{status}`

<h3 id="get__api_orders_status_{status}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|status|path|integer|true|none|

<h3 id="get__api_orders_status_{status}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Orders_change-status_{orderId}

> Code samples

`PATCH /api/Orders/change-status/{orderId}`

> Body parameter

```json
"string"
```

<h3 id="patch__api_orders_change-status_{orderid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|orderId|path|integer(int32)|true|none|
|body|body|string|true|none|

<h3 id="patch__api_orders_change-status_{orderid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-reports">Reports</h1>

## GeneratePdf

<a id="opIdGeneratePdf"></a>

> Code samples

`GET /api/Admin/Reports`

<h3 id="generatepdf-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-authentication">Authentication</h1>

## post__api_Identity_Authentication_Register

> Code samples

`POST /api/Identity/Authentication/Register`

> Body parameter

```json
{
  "fullName": "string",
  "userName": "string",
  "email": "string",
  "password": "string",
  "phoneNumber": "string"
}
```

<h3 id="post__api_identity_authentication_register-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[RegisterRequest](#schemaregisterrequest)|true|none|

> Example responses

> 200 Response

```
{"token":"string"}
```

```json
{
  "token": "string"
}
```

<h3 id="post__api_identity_authentication_register-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[UserResponse](#schemauserresponse)|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_Login

> Code samples

`POST /api/Identity/Authentication/Login`

> Body parameter

```json
{
  "email": "string",
  "password": "string"
}
```

<h3 id="post__api_identity_authentication_login-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[LoginRequest](#schemaloginrequest)|true|none|

> Example responses

> 200 Response

```
{"token":"string"}
```

```json
{
  "token": "string"
}
```

<h3 id="post__api_identity_authentication_login-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[UserResponse](#schemauserresponse)|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Identity_Authentication_ConfirmEmail

> Code samples

`GET /api/Identity/Authentication/ConfirmEmail`

<h3 id="get__api_identity_authentication_confirmemail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|token|query|string|false|none|
|userId|query|string|false|none|

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="get__api_identity_authentication_confirmemail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_forgot-password

> Code samples

`POST /api/Identity/Authentication/forgot-password`

> Body parameter

```json
{
  "email": "string"
}
```

<h3 id="post__api_identity_authentication_forgot-password-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ForgotPasswordRequest](#schemaforgotpasswordrequest)|true|none|

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="post__api_identity_authentication_forgot-password-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_reset-password

> Code samples

`POST /api/Identity/Authentication/reset-password`

> Body parameter

```json
{
  "newPassword": "string",
  "email": "string",
  "code": "string"
}
```

<h3 id="post__api_identity_authentication_reset-password-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ResetPasswordRequest](#schemaresetpasswordrequest)|true|none|

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="post__api_identity_authentication_reset-password-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-category">Category</h1>

## get__api_Customer_Category_GetAll

> Code samples

`GET /api/Customer/Category/GetAll`

<h3 id="get__api_customer_category_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Customer_Category_Get_{id}

> Code samples

`GET /api/Customer/Category/Get/{id}`

<h3 id="get__api_customer_category_get_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_customer_category_get_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Category_GetAll

> Code samples

`GET /api/Admin/Category/GetAll`

<h3 id="get__api_admin_category_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Category_Get_{id}

> Code samples

`GET /api/Admin/Category/Get/{id}`

<h3 id="get__api_admin_category_get_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_category_get_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Category_Create

> Code samples

`POST /api/Admin/Category/Create`

> Body parameter

```json
{
  "name": "string"
}
```

<h3 id="post__api_admin_category_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[CategoryRequest](#schemacategoryrequest)|true|none|

<h3 id="post__api_admin_category_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Category_Update_{id}

> Code samples

`PATCH /api/Admin/Category/Update/{id}`

> Body parameter

```json
{
  "name": "string"
}
```

<h3 id="patch__api_admin_category_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[CategoryRequest](#schemacategoryrequest)|true|none|

<h3 id="patch__api_admin_category_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Category_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Category/ToggleStatus/{id}`

<h3 id="patch__api_admin_category_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_category_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Category_Delete_{id}

> Code samples

`DELETE /api/Admin/Category/Delete/{id}`

<h3 id="delete__api_admin_category_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_category_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-brands">Brands</h1>

## get__api_Customer_Brands

> Code samples

`GET /api/Customer/Brands`

<h3 id="get__api_customer_brands-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Customer_Brands_{id}

> Code samples

`GET /api/Customer/Brands/{id}`

<h3 id="get__api_customer_brands_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_customer_brands_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Brands

> Code samples

`GET /api/Admin/Brands`

<h3 id="get__api_admin_brands-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Brands

> Code samples

`POST /api/Admin/Brands`

> Body parameter

```yaml
name: string
MainImage: string

```

<h3 id="post__api_admin_brands-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|true|none|
|» name|body|string|false|none|
|» MainImage|body|[IFormFile](#schemaiformfile)(binary)|false|none|

<h3 id="post__api_admin_brands-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Brands_{id}

> Code samples

`GET /api/Admin/Brands/{id}`

<h3 id="get__api_admin_brands_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_brands_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Brands_Update_{id}

> Code samples

`PATCH /api/Admin/Brands/Update/{id}`

> Body parameter

```json
{
  "name": "string",
  "mainImage": "string"
}
```

<h3 id="patch__api_admin_brands_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[BrandRequest](#schemabrandrequest)|true|none|

<h3 id="patch__api_admin_brands_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Brands_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Brands/ToggleStatus/{id}`

<h3 id="patch__api_admin_brands_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_brands_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Brands_Delete_{id}

> Code samples

`DELETE /api/Admin/Brands/Delete/{id}`

<h3 id="delete__api_admin_brands_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_brands_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-product">Product</h1>

## get__api_Admin_Product

> Code samples

`GET /api/Admin/Product`

<h3 id="get__api_admin_product-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|pageNumber|query|integer(int32)|false|none|
|pageSize|query|integer(int32)|false|none|

<h3 id="get__api_admin_product-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Product

> Code samples

`POST /api/Admin/Product`

> Body parameter

```yaml
Name: string
Description: string
Price: 0.1
Discount: 0.1
Quantity: 0
MainImage: string
SubImages:
  - string
Rate: 0.1
CategoryId: 0
BrandId: 0

```

<h3 id="post__api_admin_product-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|true|none|
|» Name|body|string|false|none|
|» Description|body|string|false|none|
|» Price|body|number(double)|false|none|
|» Discount|body|number(double)|false|none|
|» Quantity|body|integer(int32)|false|none|
|» MainImage|body|[IFormFile](#schemaiformfile)(binary)|false|none|
|» SubImages|body|[[IFormFile](#schemaiformfile)]|false|none|
|» Rate|body|number(double)|false|none|
|» CategoryId|body|integer(int32)|false|none|
|» BrandId|body|integer(int32)|false|none|

<h3 id="post__api_admin_product-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_BrandRequest">BrandRequest</h2>
<!-- backwards compatibility -->
<a id="schemabrandrequest"></a>
<a id="schema_BrandRequest"></a>
<a id="tocSbrandrequest"></a>
<a id="tocsbrandrequest"></a>

```json
{
  "name": "string",
  "mainImage": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string|false|none|none|
|mainImage|[IFormFile](#schemaiformfile)|false|none|none|

<h2 id="tocS_CartRequest">CartRequest</h2>
<!-- backwards compatibility -->
<a id="schemacartrequest"></a>
<a id="schema_CartRequest"></a>
<a id="tocScartrequest"></a>
<a id="tocscartrequest"></a>

```json
{
  "productId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|productId|integer(int32)|false|none|none|

<h2 id="tocS_CategoryRequest">CategoryRequest</h2>
<!-- backwards compatibility -->
<a id="schemacategoryrequest"></a>
<a id="schema_CategoryRequest"></a>
<a id="tocScategoryrequest"></a>
<a id="tocscategoryrequest"></a>

```json
{
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string|false|none|none|

<h2 id="tocS_ChangeRoleRequest">ChangeRoleRequest</h2>
<!-- backwards compatibility -->
<a id="schemachangerolerequest"></a>
<a id="schema_ChangeRoleRequest"></a>
<a id="tocSchangerolerequest"></a>
<a id="tocschangerolerequest"></a>

```json
{
  "roleName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|roleName|string|false|none|none|

<h2 id="tocS_CheckOutRequest">CheckOutRequest</h2>
<!-- backwards compatibility -->
<a id="schemacheckoutrequest"></a>
<a id="schema_CheckOutRequest"></a>
<a id="tocScheckoutrequest"></a>
<a id="tocscheckoutrequest"></a>

```json
{
  "paymentMethod": "Cash"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|paymentMethod|[PaymentMethodEnum](#schemapaymentmethodenum)|false|none|none|

<h2 id="tocS_ForgotPasswordRequest">ForgotPasswordRequest</h2>
<!-- backwards compatibility -->
<a id="schemaforgotpasswordrequest"></a>
<a id="schema_ForgotPasswordRequest"></a>
<a id="tocSforgotpasswordrequest"></a>
<a id="tocsforgotpasswordrequest"></a>

```json
{
  "email": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|email|string|false|none|none|

<h2 id="tocS_IFormFile">IFormFile</h2>
<!-- backwards compatibility -->
<a id="schemaiformfile"></a>
<a id="schema_IFormFile"></a>
<a id="tocSiformfile"></a>
<a id="tocsiformfile"></a>

```json
"string"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string(binary)|false|none|none|

<h2 id="tocS_LoginRequest">LoginRequest</h2>
<!-- backwards compatibility -->
<a id="schemaloginrequest"></a>
<a id="schema_LoginRequest"></a>
<a id="tocSloginrequest"></a>
<a id="tocsloginrequest"></a>

```json
{
  "email": "string",
  "password": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|email|string|false|none|none|
|password|string|false|none|none|

<h2 id="tocS_PaymentMethodEnum">PaymentMethodEnum</h2>
<!-- backwards compatibility -->
<a id="schemapaymentmethodenum"></a>
<a id="schema_PaymentMethodEnum"></a>
<a id="tocSpaymentmethodenum"></a>
<a id="tocspaymentmethodenum"></a>

```json
"Cash"

```

### Properties

*None*

<h2 id="tocS_RegisterRequest">RegisterRequest</h2>
<!-- backwards compatibility -->
<a id="schemaregisterrequest"></a>
<a id="schema_RegisterRequest"></a>
<a id="tocSregisterrequest"></a>
<a id="tocsregisterrequest"></a>

```json
{
  "fullName": "string",
  "userName": "string",
  "email": "string",
  "password": "string",
  "phoneNumber": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|fullName|string|false|none|none|
|userName|string|false|none|none|
|email|string|false|none|none|
|password|string|false|none|none|
|phoneNumber|string|false|none|none|

<h2 id="tocS_ResetPasswordRequest">ResetPasswordRequest</h2>
<!-- backwards compatibility -->
<a id="schemaresetpasswordrequest"></a>
<a id="schema_ResetPasswordRequest"></a>
<a id="tocSresetpasswordrequest"></a>
<a id="tocsresetpasswordrequest"></a>

```json
{
  "newPassword": "string",
  "email": "string",
  "code": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|newPassword|string|false|none|none|
|email|string|false|none|none|
|code|string|false|none|none|

<h2 id="tocS_ReviewRequest">ReviewRequest</h2>
<!-- backwards compatibility -->
<a id="schemareviewrequest"></a>
<a id="schema_ReviewRequest"></a>
<a id="tocSreviewrequest"></a>
<a id="tocsreviewrequest"></a>

```json
{
  "productId": 0,
  "comment": "string",
  "rate": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|productId|integer(int32)|false|none|none|
|comment|string¦null|false|none|none|
|rate|integer(int32)|false|none|none|

<h2 id="tocS_UserResponse">UserResponse</h2>
<!-- backwards compatibility -->
<a id="schemauserresponse"></a>
<a id="schema_UserResponse"></a>
<a id="tocSuserresponse"></a>
<a id="tocsuserresponse"></a>

```json
{
  "token": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|token|string|false|none|none|

