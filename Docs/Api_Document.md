# PL | v1
## Version: 1.0.0

<br>

## 🛰 API Endpoints Reference

| Path | Method | Summary |
| :--- | :--- | :--- |
| **🔐 Authentication & Identity** | | |
| [/api/Identity/Authentication/Register](#apiidentityauthenticationregister) | `POST` | Create a new customer account |
| [/api/Identity/Authentication/Login](#apiidentityauthenticationlogin) | `POST` | User login and JWT acquisition |
| [/api/Identity/Authentication/ConfirmEmail](#apiidentityauthenticationconfirmemail) | `GET` | Confirm email via verification token |
| [/api/Identity/Authentication/forgot-password](#apiidentityauthenticationforgot-password) | `POST` | Initiate password recovery |
| [/api/Identity/Authentication/reset-password](#apiidentityauthenticationreset-password) | `POST` | Reset password using recovery code |
| **🛒 Customer: Shopping Cart** | | |
| [/api/customer/Cart](#apicustomercart) | `POST` | Update items in the cart |
| [/api/customer/Cart](#apicustomercart) | `GET` | Retrieve current cart items |
| **💳 Customer: Checkout & Reviews** | | |
| [/api/customer/CheckOuts/payment](#apicustomercheckoutspayment) | `POST` | Process checkout and payment |
| [/api/customer/CheckOuts/Success/{orderId}](#apicustomercheckoutssuccessorderid) | `GET` | Verify successful order placement |
| [/api/customer/Reviews](#apicustomerreviews) | `POST` | Submit product feedback and rating |
| **🛍 Customer: Category & Brand Browsing** | | |
| [/api/customer/Category/GetAll](#apicustomercategorygetall) | `GET` | List all available categories |
| [/api/customer/Category/Get/{id}](#apicustomercategorygetid) | `GET` | Get category details |
| [/api/customer/Brands](#apicustomerbrands) | `GET` | List all available brands |
| [/api/customer/Brands/{id}](#apicustomerbrandsid) | `GET` | Get brand information |
| **📦 Admin: Order Management** | | |
| [/api/admin/Orders/status/{status}](#apiadminordersstatusstatus) | `GET` | Filter and view all system orders |
| [/api/admin/Orders/change-status/{orderId}](#apiadminorderschange-statusorderid) | `PATCH` | Update order fulfillment status |
| **👤 Admin: User Management** | | |
| [/api/customer/Users](#apicustomerusers) | `GET` | List all registered users |
| [/api/customer/Users/{id}](#apicustomerusersid) | `GET` | View detailed user profile |
| [/api/customer/Users/block/{userId}](#apicustomerusersblockuserid) | `PATCH` | Restrict user access (Block) |
| [/api/customer/Users/unblock/{userId}](#apicustomerusersunblockuserid) | `PATCH` | Restore user access (Unblock) |
| [/api/customer/Users/isblock/{userId}](#apicustomerusersisblockuserid) | `PATCH` | Verify user restriction status |
| [/api/customer/Users/changeRole/{userId}](#apicustomeruserschangeroleuserid) | `PATCH` | Manage user permissions/roles |
| **📂 Admin: Category Management** | | |
| [/api/admin/Category/GetAll](#apiadmincategorygetall) | `GET` | Retrieve all categories (Admin list) |
| [/api/admin/Category/Get/{id}](#apiadmincategorygetid) | `GET` | Get details of a specific category |
| [/api/admin/Category/Create](#apiadmincategorycreate) | `POST` | Create a new product category |
| [/api/admin/Category/Update/{id}](#apiadmincategoryupdateid) | `PATCH` | Update existing category details |
| [/api/admin/Category/ToggleStatus/{id}](#apiadmincategorytogglestatusid) | `PATCH` | Activate/Deactivate a category status |
| [/api/admin/Category/Delete/{id}](#apiadmincategorydeleteid) | `DELETE` | Permanently remove a category |
| **🏷 Admin: Brand Management** | | |
| [/api/admin/Brands](#apiadminbrands) | `GET` | List all store brands (Admin view) |
| [/api/admin/Brands](#apiadminbrands) | `POST` | Create a new brand |
| [/api/admin/Brands/{id}](#apiadminbrandsid) | `GET` | View specific brand details |
| [/api/admin/Brands/Update/{id}](#apiadminbrandsupdateid) | `PATCH` | Update brand name or details |
| [/api/admin/Brands/ToggleStatus/{id}](#apiadminbrandstogglestatusid) | `PATCH` | Enable/Disable brand visibility |
| [/api/admin/Brands/Delete/{id}](#apiadminbrandsdeleteid) | `DELETE` | Permanently remove a brand |
| **✨ Admin: Product Management** | | |
| [/api/admin/Product](#apiadminproduct) | `GET` | List products with Pagination (pageNumber, pageSize) |
| [/api/admin/Product](#apiadminproduct) | `POST` | Upload and create a new product |
| **📊 Admin: Reports** | | |
| [/api/admin/Reports](#apiadminreports) | `GET` | Generate sales and user activity reports |

<br>
<hr>
<br>


### /api/customer/Cart

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/CheckOuts/payment

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/CheckOuts/Success/{orderId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| orderId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Reviews

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Orders/status/{status}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| status | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Orders/change-status/{orderId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| orderId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Reports

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Users

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Users/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Users/block/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Users/unblock/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Users/isblock/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Users/changeRole/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/Register

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/Login

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/ConfirmEmail

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| token | query |  | No | string |
| userId | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/forgot-password

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/reset-password

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Category/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Category/Get/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Brands

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Brands/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Brands

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Brands/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Brands/Update/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Brands/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Brands/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Category/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Category/Get/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Category/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Category/Update/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Category/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Category/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/admin/Product

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| pageNumber | query |  | No | integer |
| pageSize | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### Models


#### BrandRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| name | string |  | No |
| mainImage | [IFormFile](#iformfile) |  | No |

#### CartRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| productId | integer |  | No |

#### CategoryRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| name | string |  | No |

#### ChangeRoleRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| roleName | string |  | No |

#### CheckOutRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| paymentMethod | [PaymentMethodEnum](#paymentmethodenum) |  | No |

#### ForgotPasswordRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| email | string |  | No |

#### IFormFile

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| IFormFile | string |  |  |

#### LoginRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| email | string |  | No |
| password | string |  | No |

#### PaymentMethodEnum

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| PaymentMethodEnum |  |  |  |

#### RegisterRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| fullName | string |  | No |
| userName | string |  | No |
| email | string |  | No |
| password | string |  | No |
| phoneNumber | string |  | No |

#### ResetPasswordRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| newPassword | string |  | No |
| email | string |  | No |
| code | string |  | No |

#### ReviewRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| productId | integer |  | No |
| comment | string |  | No |
| rate | integer |  | No |

#### UserResponse

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| token | string |  | No |
