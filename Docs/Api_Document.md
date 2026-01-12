# PL | v1
## Version: 1.0.0

<br>
<hr>

## 🛰 API Endpoints Reference

| Path | Method | Summary |
| :--- | :--- | :--- |
| **Authentication & Identity** | | |
| [/api/Identity/Authentication/Register](#apiidentityauthenticationregister) | `POST` | Register a new user |
| [/api/Identity/Authentication/Login](#apiidentityauthenticationlogin) | `POST` | Authenticate and get token |
| [/api/Identity/Authentication/ConfirmEmail](#apiidentityauthenticationconfirmemail) | `GET` | Verify user email address |
| [/api/Identity/Authentication/forgot-password](#apiidentityauthenticationforgot-password) | `POST` | Request password reset |
| [/api/Identity/Authentication/reset-password](#apiidentityauthenticationreset-password) | `POST` | Reset password with token |
| **Shopping Cart** | | |
| [/api/Customer/Cart](#apicustomercart) | `POST` | Add/Update items in cart |
| [/api/Customer/Cart](#apicustomercart) | `GET` | Retrieve customer cart |
| **Checkout & Payments** | | |
| [/api/customer/CheckOuts/payment](#apicustomercheckoutspayment) | `POST` | Process order payment |
| [/api/customer/CheckOuts/Success/{orderId}](#apicustomercheckoutssuccessorderid) | `GET` | Handle successful payment callback |
| **Order Management** | | |
| [/api/Orders/status/{status}](#apiordersstatusstatus) | `GET` | Filter orders by status |
| [/api/Orders/change-status/{orderId}](#apiorderschangestatusorderid) | `PATCH` | Update order progress status |
| **Customer User Management** | | |
| [/api/customer/Users](#apicustomerusers) | `GET` | List all users (Admin) |
| [/api/customer/Users/{id}](#apicustomerusersid) | `GET` | Get user details by ID |
| [/api/customer/Users/block/{userId}](#apicustomerusersblockuserid) | `PATCH` | Block a user account |
| [/api/customer/Users/unblock/{userId}](#apicustomerusersunblockuserid) | `PATCH` | Unblock a user account |
| [/api/customer/Users/isblock/{userId}](#apicustomerusersisblockuserid) | `PATCH` | Check if user is blocked |
| [/api/customer/Users/changeRole/{userId}](#apicustomeruserschangeroleuserid) | `PATCH` | Update user permissions/roles |
| **Categories & Catalog** | | |
| [/api/Customer/Category/GetAll](#apicustomercategorygetall) | `GET` | List all active categories |
| [/api/Customer/Category/Get/{id}](#apicustomercategorygetid) | `GET` | Get category details by ID |
| **Brand Management (Customer)** | | |
| [/api/Customer/Brands](#apicustomerbrands) | `GET` | List all available brands |
| [/api/Customer/Brands/{id}](#apicustomerbrandsid) | `GET` | Get brand details |
| **Brand Management (Admin)** | | |
| [/api/Admin/Brands](#apiadminbrands) | `GET` | List all brands (incl. inactive) |
| [/api/Admin/Brands](#apiadminbrands) | `POST` | Create a new brand |
| [/api/Admin/Brands/{id}](#apiadminbrandsid) | `GET` | Get brand details (Admin view) |
| [/api/Admin/Brands/Update/{id}](#apiadminbrandsupdateid) | `PATCH` | Modify brand information |
| [/api/Admin/Brands/ToggleStatus/{id}](#apiadminbrandstogglestatusid) | `PATCH` | Activate/Deactivate a brand |
| [/api/Admin/Brands/Delete/{id}](#apiadminbrandsdeleteid) | `DELETE` | Permanently remove a brand |
| **Reviews & Analytics** | | |
| [/api/customer/Reviews](#apicustomerreviews) | `POST` | Submit a product review |
| [/api/Admin/Reports](#apiadminreports) | `GET` | Generate platform sales reports |


<br>
<hr>


### /api/Customer/Cart

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

### /api/customer/Users

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Users/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Users/block/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Users/unblock/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Users/isblock/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/customer/Users/changeRole/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Orders/status/{status}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| status | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Orders/change-status/{orderId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| orderId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Reports

#### GET
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

### /api/Customer/Category/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Customer/Category/Get/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Customer/Brands

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Customer/Brands/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Brands

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

### /api/Admin/Brands/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Brands/Update/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Brands/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Brands/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Get/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Update/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Product

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
