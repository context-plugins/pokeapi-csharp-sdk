# Reference

> Source: [PokApiClient](PokApiClient.cs)

## Berries

> Source: [Berries](Api/Berries.cs)

<details>
<summary><code>Task&lt;PaginatedBerryFirmnessSummaryList&gt; BerryFirmnessList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Berries can be soft or hard. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Category:Berries_by_firmness) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Berries.BerryFirmnessList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedBerryFirmnessSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedBerryFirmnessSummaryList](Models/PaginatedBerryFirmnessSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BerryFirmnessDetail&gt; BerryFirmnessRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Berries can be soft or hard. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Category:Berries_by_firmness) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Berries.BerryFirmnessRetrieve(id);
    // TODO: Handle 'response' of type BerryFirmnessDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BerryFirmnessDetail](Models/BerryFirmnessDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedBerryFlavorSummaryList&gt; BerryFlavorList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Flavors determine whether a Pokémon will benefit or suffer from eating a berry based on their **nature**. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Flavor) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Berries.BerryFlavorList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedBerryFlavorSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedBerryFlavorSummaryList](Models/PaginatedBerryFlavorSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BerryFlavorDetail&gt; BerryFlavorRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Flavors determine whether a Pokémon will benefit or suffer from eating a berry based on their **nature**. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Flavor) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Berries.BerryFlavorRetrieve(id);
    // TODO: Handle 'response' of type BerryFlavorDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BerryFlavorDetail](Models/BerryFlavorDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedBerrySummaryList&gt; BerryList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Berries are small fruits that can provide HP and status condition restoration, stat enhancement, and even damage negation when eaten by Pokémon. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Berry) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Berries.BerryList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedBerrySummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedBerrySummaryList](Models/PaginatedBerrySummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BerryDetail&gt; BerryRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Berries are small fruits that can provide HP and status condition restoration, stat enhancement, and even damage negation when eaten by Pokémon. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Berry) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Berries.BerryRetrieve(id);
    // TODO: Handle 'response' of type BerryDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BerryDetail](Models/BerryDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Contests

> Source: [Contests](Api/Contests.cs)

<details>
<summary><code>Task&lt;PaginatedContestEffectSummaryList&gt; ContestEffectList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Contest effects refer to the effects of moves when used in contests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contests.ContestEffectList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedContestEffectSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedContestEffectSummaryList](Models/PaginatedContestEffectSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ContestEffectDetail&gt; ContestEffectRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Contest effects refer to the effects of moves when used in contests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contests.ContestEffectRetrieve(id);
    // TODO: Handle 'response' of type ContestEffectDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContestEffectDetail](Models/ContestEffectDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedContestTypeSummaryList&gt; ContestTypeList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Contest types are categories judges used to weigh a Pokémon's condition in Pokémon contests. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Contest_condition) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contests.ContestTypeList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedContestTypeSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedContestTypeSummaryList](Models/PaginatedContestTypeSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ContestTypeDetail&gt; ContestTypeRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Contest types are categories judges used to weigh a Pokémon's condition in Pokémon contests. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Contest_condition) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contests.ContestTypeRetrieve(id);
    // TODO: Handle 'response' of type ContestTypeDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContestTypeDetail](Models/ContestTypeDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedSuperContestEffectSummaryList&gt; SuperContestEffectList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Super contest effects refer to the effects of moves when used in super contests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contests.SuperContestEffectList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedSuperContestEffectSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedSuperContestEffectSummaryList](Models/PaginatedSuperContestEffectSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SuperContestEffectDetail&gt; SuperContestEffectRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Super contest effects refer to the effects of moves when used in super contests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contests.SuperContestEffectRetrieve(id);
    // TODO: Handle 'response' of type SuperContestEffectDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SuperContestEffectDetail](Models/SuperContestEffectDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Encounters

> Source: [Encounters](Api/Encounters.cs)

<details>
<summary><code>Task&lt;PaginatedEncounterConditionSummaryList&gt; EncounterConditionList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Conditions which affect what pokemon might appear in the wild, e.g., day or night.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.EncounterConditionList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedEncounterConditionSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedEncounterConditionSummaryList](Models/PaginatedEncounterConditionSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EncounterConditionDetail&gt; EncounterConditionRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Conditions which affect what pokemon might appear in the wild, e.g., day or night.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.EncounterConditionRetrieve(id);
    // TODO: Handle 'response' of type EncounterConditionDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EncounterConditionDetail](Models/EncounterConditionDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedEncounterConditionValueSummaryList&gt; EncounterConditionValueList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Encounter condition values are the various states that an encounter condition can have, i.e., time of day can be either day or night.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.EncounterConditionValueList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedEncounterConditionValueSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedEncounterConditionValueSummaryList](Models/PaginatedEncounterConditionValueSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EncounterConditionValueDetail&gt; EncounterConditionValueRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Encounter condition values are the various states that an encounter condition can have, i.e., time of day can be either day or night.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.EncounterConditionValueRetrieve(id);
    // TODO: Handle 'response' of type EncounterConditionValueDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EncounterConditionValueDetail](Models/EncounterConditionValueDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedEncounterMethodSummaryList&gt; EncounterMethodList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Methods by which the player might can encounter Pokémon in the wild, e.g., walking in tall grass. Check out Bulbapedia for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.EncounterMethodList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedEncounterMethodSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedEncounterMethodSummaryList](Models/PaginatedEncounterMethodSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EncounterMethodDetail&gt; EncounterMethodRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Methods by which the player might can encounter Pokémon in the wild, e.g., walking in tall grass. Check out Bulbapedia for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.EncounterMethodRetrieve(id);
    // TODO: Handle 'response' of type EncounterMethodDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EncounterMethodDetail](Models/EncounterMethodDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV2PokemonEncountersResponse&gt;&gt; PokemonEncountersRetrieve(string pokemonId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Handles Pokemon Encounters as a sub-resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Encounters.PokemonEncountersRetrieve(pokemonId);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV2PokemonEncountersResponse>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pokemonId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV2PokemonEncountersResponse](Models/ApiV2PokemonEncountersResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Evolution

> Source: [Evolution](Api/Evolution.cs)

<details>
<summary><code>Task&lt;PaginatedEvolutionChainSummaryList&gt; EvolutionChainList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Evolution chains are essentially family trees. They start with the lowest stage within a family and detail evolution conditions for each as well as Pokémon they can evolve into up through the hierarchy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evolution.EvolutionChainList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedEvolutionChainSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedEvolutionChainSummaryList](Models/PaginatedEvolutionChainSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EvolutionChainDetail&gt; EvolutionChainRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Evolution chains are essentially family trees. They start with the lowest stage within a family and detail evolution conditions for each as well as Pokémon they can evolve into up through the hierarchy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evolution.EvolutionChainRetrieve(id);
    // TODO: Handle 'response' of type EvolutionChainDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EvolutionChainDetail](Models/EvolutionChainDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedEvolutionTriggerSummaryList&gt; EvolutionTriggerList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Evolution triggers are the events and conditions that cause a Pokémon to evolve. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Methods_of_evolution) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evolution.EvolutionTriggerList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedEvolutionTriggerSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedEvolutionTriggerSummaryList](Models/PaginatedEvolutionTriggerSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EvolutionTriggerDetail&gt; EvolutionTriggerRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Evolution triggers are the events and conditions that cause a Pokémon to evolve. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Methods_of_evolution) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evolution.EvolutionTriggerRetrieve(id);
    // TODO: Handle 'response' of type EvolutionTriggerDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EvolutionTriggerDetail](Models/EvolutionTriggerDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Games

> Source: [Games](Api/Games.cs)

<details>
<summary><code>Task&lt;PaginatedGenerationSummaryList&gt; GenerationList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A generation is a grouping of the Pokémon games that separates them based on the Pokémon they include. In each generation, a new set of Pokémon, Moves, Abilities and Types that did not exist in the previous generation are released.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.GenerationList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedGenerationSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGenerationSummaryList](Models/PaginatedGenerationSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerationDetail&gt; GenerationRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A generation is a grouping of the Pokémon games that separates them based on the Pokémon they include. In each generation, a new set of Pokémon, Moves, Abilities and Types that did not exist in the previous generation are released.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.GenerationRetrieve(id);
    // TODO: Handle 'response' of type GenerationDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerationDetail](Models/GenerationDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokedexSummaryList&gt; PokedexList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A Pokédex is a handheld electronic encyclopedia device; one which is capable of recording and retaining information of the various Pokémon in a given region with the exception of the national dex and some smaller dexes related to portions of a region. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Pokedex) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.PokedexList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokedexSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokedexSummaryList](Models/PaginatedPokedexSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokedexDetail&gt; PokedexRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A Pokédex is a handheld electronic encyclopedia device; one which is capable of recording and retaining information of the various Pokémon in a given region with the exception of the national dex and some smaller dexes related to portions of a region. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Pokedex) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.PokedexRetrieve(id);
    // TODO: Handle 'response' of type PokedexDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokedexDetail](Models/PokedexDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedVersionGroupSummaryList&gt; VersionGroupList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Version groups categorize highly similar versions of the games.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.VersionGroupList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedVersionGroupSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedVersionGroupSummaryList](Models/PaginatedVersionGroupSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VersionGroupDetail&gt; VersionGroupRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Version groups categorize highly similar versions of the games.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.VersionGroupRetrieve(id);
    // TODO: Handle 'response' of type VersionGroupDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VersionGroupDetail](Models/VersionGroupDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedVersionSummaryList&gt; VersionList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Versions of the games, e.g., Red, Blue or Yellow.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.VersionList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedVersionSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedVersionSummaryList](Models/PaginatedVersionSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VersionDetail&gt; VersionRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Versions of the games, e.g., Red, Blue or Yellow.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Games.VersionRetrieve(id);
    // TODO: Handle 'response' of type VersionDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VersionDetail](Models/VersionDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Items

> Source: [Items](Api/Items.cs)

<details>
<summary><code>Task&lt;PaginatedItemAttributeSummaryList&gt; ItemAttributeList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Item attributes define particular aspects of items, e.g."usable in battle" or "consumable".

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemAttributeList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedItemAttributeSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedItemAttributeSummaryList](Models/PaginatedItemAttributeSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemAttributeDetail&gt; ItemAttributeRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Item attributes define particular aspects of items, e.g."usable in battle" or "consumable".

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemAttributeRetrieve(id);
    // TODO: Handle 'response' of type ItemAttributeDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemAttributeDetail](Models/ItemAttributeDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedItemCategorySummaryList&gt; ItemCategoryList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Item categories determine where items will be placed in the players bag.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemCategoryList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedItemCategorySummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedItemCategorySummaryList](Models/PaginatedItemCategorySummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemCategoryDetail&gt; ItemCategoryRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Item categories determine where items will be placed in the players bag.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemCategoryRetrieve(id);
    // TODO: Handle 'response' of type ItemCategoryDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemCategoryDetail](Models/ItemCategoryDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedItemFlingEffectSummaryList&gt; ItemFlingEffectList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The various effects of the move"Fling" when used with different items.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemFlingEffectList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedItemFlingEffectSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedItemFlingEffectSummaryList](Models/PaginatedItemFlingEffectSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemFlingEffectDetail&gt; ItemFlingEffectRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The various effects of the move"Fling" when used with different items.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemFlingEffectRetrieve(id);
    // TODO: Handle 'response' of type ItemFlingEffectDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemFlingEffectDetail](Models/ItemFlingEffectDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedItemSummaryList&gt; ItemList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An item is an object in the games which the player can pick up, keep in their bag, and use in some manner. They have various uses, including healing, powering up, helping catch Pokémon, or to access a new area.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedItemSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedItemSummaryList](Models/PaginatedItemSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedItemPocketSummaryList&gt; ItemPocketList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pockets within the players bag used for storing items by category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemPocketList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedItemPocketSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedItemPocketSummaryList](Models/PaginatedItemPocketSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemPocketDetail&gt; ItemPocketRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pockets within the players bag used for storing items by category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemPocketRetrieve(id);
    // TODO: Handle 'response' of type ItemPocketDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemPocketDetail](Models/ItemPocketDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemDetail&gt; ItemRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An item is an object in the games which the player can pick up, keep in their bag, and use in some manner. They have various uses, including healing, powering up, helping catch Pokémon, or to access a new area.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Items.ItemRetrieve(id);
    // TODO: Handle 'response' of type ItemDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemDetail](Models/ItemDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LocationApi

> Source: [LocationApi](Api/LocationApi.cs)

<details>
<summary><code>Task&lt;PaginatedLocationAreaSummaryList&gt; LocationAreaList(int? limit, int? offset, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Location areas are sections of areas, such as floors in a building or cave. Each area has its own set of possible Pokémon encounters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.LocationAreaList(limit, offset);
    // TODO: Handle 'response' of type PaginatedLocationAreaSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedLocationAreaSummaryList](Models/PaginatedLocationAreaSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LocationAreaDetail&gt; LocationAreaRetrieve(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Location areas are sections of areas, such as floors in a building or cave. Each area has its own set of possible Pokémon encounters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.LocationAreaRetrieve(id);
    // TODO: Handle 'response' of type LocationAreaDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | A unique integer value identifying this location area. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LocationAreaDetail](Models/LocationAreaDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedLocationSummaryList&gt; LocationList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Locations that can be visited within the games. Locations make up sizable portions of regions, like cities or routes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.LocationList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedLocationSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedLocationSummaryList](Models/PaginatedLocationSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LocationDetail&gt; LocationRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Locations that can be visited within the games. Locations make up sizable portions of regions, like cities or routes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.LocationRetrieve(id);
    // TODO: Handle 'response' of type LocationDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LocationDetail](Models/LocationDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPalParkAreaSummaryList&gt; PalParkAreaList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Areas used for grouping Pokémon encounters in Pal Park. They're like habitats that are specific to Pal Park.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.PalParkAreaList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPalParkAreaSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPalParkAreaSummaryList](Models/PaginatedPalParkAreaSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PalParkAreaDetail&gt; PalParkAreaRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Areas used for grouping Pokémon encounters in Pal Park. They're like habitats that are specific to Pal Park.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.PalParkAreaRetrieve(id);
    // TODO: Handle 'response' of type PalParkAreaDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PalParkAreaDetail](Models/PalParkAreaDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedRegionSummaryList&gt; RegionList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A region is an organized area of the Pokémon world. Most often, the main difference between regions is the species of Pokémon that can be encountered within them.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.RegionList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedRegionSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedRegionSummaryList](Models/PaginatedRegionSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegionDetail&gt; RegionRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A region is an organized area of the Pokémon world. Most often, the main difference between regions is the species of Pokémon that can be encountered within them.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationApi.RegionRetrieve(id);
    // TODO: Handle 'response' of type RegionDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegionDetail](Models/RegionDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Machines

> Source: [Machines](Api/Machines.cs)

<details>
<summary><code>Task&lt;PaginatedMachineSummaryList&gt; MachineList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Machines are the representation of items that teach moves to Pokémon. They vary from version to version, so it is not certain that one specific TM or HM corresponds to a single Machine.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Machines.MachineList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMachineSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMachineSummaryList](Models/PaginatedMachineSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MachineDetail&gt; MachineRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Machines are the representation of items that teach moves to Pokémon. They vary from version to version, so it is not certain that one specific TM or HM corresponds to a single Machine.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Machines.MachineRetrieve(id);
    // TODO: Handle 'response' of type MachineDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MachineDetail](Models/MachineDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Moves

> Source: [Moves](Api/Moves.cs)

<details>
<summary><code>Task&lt;PaginatedMoveMetaAilmentSummaryList&gt; MoveAilmentList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Move Ailments are status conditions caused by moves used during battle. See [Bulbapedia](https://bulbapedia.bulbagarden.net/wiki/Status_condition) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveAilmentList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveMetaAilmentSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveMetaAilmentSummaryList](Models/PaginatedMoveMetaAilmentSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveMetaAilmentDetail&gt; MoveAilmentRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Move Ailments are status conditions caused by moves used during battle. See [Bulbapedia](https://bulbapedia.bulbagarden.net/wiki/Status_condition) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveAilmentRetrieve(id);
    // TODO: Handle 'response' of type MoveMetaAilmentDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveMetaAilmentDetail](Models/MoveMetaAilmentDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedMoveBattleStyleSummaryList&gt; MoveBattleStyleList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Styles of moves when used in the Battle Palace. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Battle_Frontier_(Generation_III)) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveBattleStyleList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveBattleStyleSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveBattleStyleSummaryList](Models/PaginatedMoveBattleStyleSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveBattleStyleDetail&gt; MoveBattleStyleRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Styles of moves when used in the Battle Palace. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Battle_Frontier_(Generation_III)) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveBattleStyleRetrieve(id);
    // TODO: Handle 'response' of type MoveBattleStyleDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveBattleStyleDetail](Models/MoveBattleStyleDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedMoveMetaCategorySummaryList&gt; MoveCategoryList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Very general categories that loosely group move effects.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveCategoryList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveMetaCategorySummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveMetaCategorySummaryList](Models/PaginatedMoveMetaCategorySummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveMetaCategoryDetail&gt; MoveCategoryRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Very general categories that loosely group move effects.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveCategoryRetrieve(id);
    // TODO: Handle 'response' of type MoveMetaCategoryDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveMetaCategoryDetail](Models/MoveMetaCategoryDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedMoveLearnMethodSummaryList&gt; MoveLearnMethodList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Methods by which Pokémon can learn moves.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveLearnMethodList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveLearnMethodSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveLearnMethodSummaryList](Models/PaginatedMoveLearnMethodSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveLearnMethodDetail&gt; MoveLearnMethodRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Methods by which Pokémon can learn moves.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveLearnMethodRetrieve(id);
    // TODO: Handle 'response' of type MoveLearnMethodDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveLearnMethodDetail](Models/MoveLearnMethodDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedMoveSummaryList&gt; MoveList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Moves are the skills of Pokémon in battle. In battle, a Pokémon uses one move each turn. Some moves (including those learned by Hidden Machine) can be used outside of battle as well, usually for the purpose of removing obstacles or exploring new areas.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveSummaryList](Models/PaginatedMoveSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveDetail&gt; MoveRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Moves are the skills of Pokémon in battle. In battle, a Pokémon uses one move each turn. Some moves (including those learned by Hidden Machine) can be used outside of battle as well, usually for the purpose of removing obstacles or exploring new areas.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveRetrieve(id);
    // TODO: Handle 'response' of type MoveDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveDetail](Models/MoveDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedMoveTargetSummaryList&gt; MoveTargetList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Targets moves can be directed at during battle. Targets can be Pokémon, environments or even other moves.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveTargetList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveTargetSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveTargetSummaryList](Models/PaginatedMoveTargetSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveTargetDetail&gt; MoveTargetRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Targets moves can be directed at during battle. Targets can be Pokémon, environments or even other moves.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Moves.MoveTargetRetrieve(id);
    // TODO: Handle 'response' of type MoveTargetDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveTargetDetail](Models/MoveTargetDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PokemonApi

> Source: [PokemonApi](Api/PokemonApi.cs)

<details>
<summary><code>Task&lt;PaginatedAbilitySummaryList&gt; AbilityList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Abilities provide passive effects for Pokémon in battle or in the overworld. Pokémon have multiple possible abilities but can have only one ability at a time. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Ability) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.AbilityList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedAbilitySummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedAbilitySummaryList](Models/PaginatedAbilitySummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AbilityDetail&gt; AbilityRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Abilities provide passive effects for Pokémon in battle or in the overworld. Pokémon have multiple possible abilities but can have only one ability at a time. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Ability) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.AbilityRetrieve(id);
    // TODO: Handle 'response' of type AbilityDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AbilityDetail](Models/AbilityDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedCharacteristicSummaryList&gt; CharacteristicList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Characteristics indicate which stat contains a Pokémon's highest IV. A Pokémon's Characteristic is determined by the remainder of its highest IV divided by 5 (gene_modulo). Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Characteristic) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.CharacteristicList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedCharacteristicSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedCharacteristicSummaryList](Models/PaginatedCharacteristicSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CharacteristicDetail&gt; CharacteristicRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Characteristics indicate which stat contains a Pokémon's highest IV. A Pokémon's Characteristic is determined by the remainder of its highest IV divided by 5 (gene_modulo). Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Characteristic) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.CharacteristicRetrieve(id);
    // TODO: Handle 'response' of type CharacteristicDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CharacteristicDetail](Models/CharacteristicDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedEggGroupSummaryList&gt; EggGroupList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Egg Groups are categories which determine which Pokémon are able to interbreed. Pokémon may belong to either one or two Egg Groups. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Egg_Group) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.EggGroupList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedEggGroupSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedEggGroupSummaryList](Models/PaginatedEggGroupSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EggGroupDetail&gt; EggGroupRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Egg Groups are categories which determine which Pokémon are able to interbreed. Pokémon may belong to either one or two Egg Groups. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Egg_Group) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.EggGroupRetrieve(id);
    // TODO: Handle 'response' of type EggGroupDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EggGroupDetail](Models/EggGroupDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedGenderSummaryList&gt; GenderList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Genders were introduced in Generation II for the purposes of breeding Pokémon but can also result in visual differences or even different evolutionary lines. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Gender) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.GenderList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedGenderSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGenderSummaryList](Models/PaginatedGenderSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenderDetail&gt; GenderRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Genders were introduced in Generation II for the purposes of breeding Pokémon but can also result in visual differences or even different evolutionary lines. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Gender) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.GenderRetrieve(id);
    // TODO: Handle 'response' of type GenderDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenderDetail](Models/GenderDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedGrowthRateSummaryList&gt; GrowthRateList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Growth rates are the speed with which Pokémon gain levels through experience. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Experience) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.GrowthRateList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedGrowthRateSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGrowthRateSummaryList](Models/PaginatedGrowthRateSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrowthRateDetail&gt; GrowthRateRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Growth rates are the speed with which Pokémon gain levels through experience. Check out [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Experience) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.GrowthRateRetrieve(id);
    // TODO: Handle 'response' of type GrowthRateDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrowthRateDetail](Models/GrowthRateDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedMoveDamageClassSummaryList&gt; MoveDamageClassList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Damage classes moves can have, e.g. physical, special, or non-damaging.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.MoveDamageClassList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedMoveDamageClassSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedMoveDamageClassSummaryList](Models/PaginatedMoveDamageClassSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MoveDamageClassDetail&gt; MoveDamageClassRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Damage classes moves can have, e.g. physical, special, or non-damaging.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.MoveDamageClassRetrieve(id);
    // TODO: Handle 'response' of type MoveDamageClassDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MoveDamageClassDetail](Models/MoveDamageClassDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedNatureSummaryList&gt; NatureList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Natures influence how a Pokémon's stats grow. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Nature) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.NatureList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedNatureSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedNatureSummaryList](Models/PaginatedNatureSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NatureDetail&gt; NatureRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Natures influence how a Pokémon's stats grow. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Nature) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.NatureRetrieve(id);
    // TODO: Handle 'response' of type NatureDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NatureDetail](Models/NatureDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokeathlonStatSummaryList&gt; PokeathlonStatList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pokeathlon Stats are different attributes of a Pokémon's performance in Pokéathlons. In Pokéathlons, competitions happen on different courses; one for each of the different Pokéathlon stats. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Pok%C3%A9athlon) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokeathlonStatList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokeathlonStatSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokeathlonStatSummaryList](Models/PaginatedPokeathlonStatSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokeathlonStatDetail&gt; PokeathlonStatRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pokeathlon Stats are different attributes of a Pokémon's performance in Pokéathlons. In Pokéathlons, competitions happen on different courses; one for each of the different Pokéathlon stats. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Pok%C3%A9athlon) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokeathlonStatRetrieve(id);
    // TODO: Handle 'response' of type PokeathlonStatDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokeathlonStatDetail](Models/PokeathlonStatDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokemonColorSummaryList&gt; PokemonColorList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Colors used for sorting Pokémon in a Pokédex. The color listed in the Pokédex is usually the color most apparent or covering each Pokémon's body. No orange category exists; Pokémon that are primarily orange are listed as red or brown.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonColorList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokemonColorSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokemonColorSummaryList](Models/PaginatedPokemonColorSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokemonColorDetail&gt; PokemonColorRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Colors used for sorting Pokémon in a Pokédex. The color listed in the Pokédex is usually the color most apparent or covering each Pokémon's body. No orange category exists; Pokémon that are primarily orange are listed as red or brown.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonColorRetrieve(id);
    // TODO: Handle 'response' of type PokemonColorDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokemonColorDetail](Models/PokemonColorDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokemonFormSummaryList&gt; PokemonFormList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Some Pokémon may appear in one of multiple, visually different forms. These differences are purely cosmetic. For variations within a Pokémon species, which do differ in more than just visuals, the 'Pokémon' entity is used to represent such a variety.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonFormList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokemonFormSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokemonFormSummaryList](Models/PaginatedPokemonFormSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokemonFormDetail&gt; PokemonFormRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Some Pokémon may appear in one of multiple, visually different forms. These differences are purely cosmetic. For variations within a Pokémon species, which do differ in more than just visuals, the 'Pokémon' entity is used to represent such a variety.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonFormRetrieve(id);
    // TODO: Handle 'response' of type PokemonFormDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokemonFormDetail](Models/PokemonFormDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokemonHabitatSummaryList&gt; PokemonHabitatList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Habitats are generally different terrain Pokémon can be found in but can also be areas designated for rare or legendary Pokémon.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonHabitatList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokemonHabitatSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokemonHabitatSummaryList](Models/PaginatedPokemonHabitatSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokemonHabitatDetail&gt; PokemonHabitatRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Habitats are generally different terrain Pokémon can be found in but can also be areas designated for rare or legendary Pokémon.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonHabitatRetrieve(id);
    // TODO: Handle 'response' of type PokemonHabitatDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokemonHabitatDetail](Models/PokemonHabitatDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokemonSummaryList&gt; PokemonList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pokémon are the creatures that inhabit the world of the Pokémon games. They can be caught using Pokéballs and trained by battling with other Pokémon. Each Pokémon belongs to a specific species but may take on a variant which makes it differ from other Pokémon of the same species, such as base stats, available abilities and typings. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Pok%C3%A9mon_(species)) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokemonSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokemonSummaryList](Models/PaginatedPokemonSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokemonDetail&gt; PokemonRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pokémon are the creatures that inhabit the world of the Pokémon games. They can be caught using Pokéballs and trained by battling with other Pokémon. Each Pokémon belongs to a specific species but may take on a variant which makes it differ from other Pokémon of the same species, such as base stats, available abilities and typings. See [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Pok%C3%A9mon_(species)) for greater detail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonRetrieve(id);
    // TODO: Handle 'response' of type PokemonDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokemonDetail](Models/PokemonDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokemonShapeSummaryList&gt; PokemonShapeList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shapes used for sorting Pokémon in a Pokédex.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonShapeList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokemonShapeSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokemonShapeSummaryList](Models/PaginatedPokemonShapeSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokemonShapeDetail&gt; PokemonShapeRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shapes used for sorting Pokémon in a Pokédex.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonShapeRetrieve(id);
    // TODO: Handle 'response' of type PokemonShapeDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokemonShapeDetail](Models/PokemonShapeDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPokemonSpeciesSummaryList&gt; PokemonSpeciesList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A Pokémon Species forms the basis for at least one Pokémon. Attributes of a Pokémon species are shared across all varieties of Pokémon within the species. A good example is Wormadam; Wormadam is the species which can be found in three different varieties, Wormadam-Trash, Wormadam-Sandy and Wormadam-Plant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonSpeciesList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedPokemonSpeciesSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPokemonSpeciesSummaryList](Models/PaginatedPokemonSpeciesSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PokemonSpeciesDetail&gt; PokemonSpeciesRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A Pokémon Species forms the basis for at least one Pokémon. Attributes of a Pokémon species are shared across all varieties of Pokémon within the species. A good example is Wormadam; Wormadam is the species which can be found in three different varieties, Wormadam-Trash, Wormadam-Sandy and Wormadam-Plant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.PokemonSpeciesRetrieve(id);
    // TODO: Handle 'response' of type PokemonSpeciesDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PokemonSpeciesDetail](Models/PokemonSpeciesDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedStatSummaryList&gt; StatList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stats determine certain aspects of battles. Each Pokémon has a value for each stat which grows as they gain levels and can be altered momentarily by effects in battles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.StatList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedStatSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedStatSummaryList](Models/PaginatedStatSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatDetail&gt; StatRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stats determine certain aspects of battles. Each Pokémon has a value for each stat which grows as they gain levels and can be altered momentarily by effects in battles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.StatRetrieve(id);
    // TODO: Handle 'response' of type StatDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatDetail](Models/StatDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedTypeSummaryList&gt; TypeList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Types are properties for Pokémon and their moves. Each type has three properties: which types of Pokémon it is super effective against, which types of Pokémon it is not very effective against, and which types of Pokémon it is completely ineffective against.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.TypeList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedTypeSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedTypeSummaryList](Models/PaginatedTypeSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TypeDetail&gt; TypeRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Types are properties for Pokémon and their moves. Each type has three properties: which types of Pokémon it is super effective against, which types of Pokémon it is not very effective against, and which types of Pokémon it is completely ineffective against.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PokemonApi.TypeRetrieve(id);
    // TODO: Handle 'response' of type TypeDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TypeDetail](Models/TypeDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Utility

> Source: [Utility](Api/Utility.cs)

<details>
<summary><code>Task&lt;PaginatedLanguageSummaryList&gt; LanguageList(int? limit, int? offset, string? q, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Languages for translations of API resource information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.LanguageList(limit, offset, q);
    // TODO: Handle 'response' of type PaginatedLanguageSummaryList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | Number of results to return per page. |
| <code>offset</code> | <code>int?</code> | The initial index from which to return the results. |
| <code>q</code> | <code>string?</code> | > Only available locally and not at [pokeapi.co](https://pokeapi.co/docs/v2)<br>Case-insensitive query applied on the `name` property. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedLanguageSummaryList](Models/PaginatedLanguageSummaryList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LanguageDetail&gt; LanguageRetrieve(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Languages for translations of API resource information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.LanguageRetrieve(id);
    // TODO: Handle 'response' of type LanguageDetail
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | This parameter can be a string or an integer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LanguageDetail](Models/LanguageDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV2MetaResponse&gt; MetaRetrieve(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns metadata about the current deployed version of the API, including the git commit hash, deploy date, and tag (if any).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.MetaRetrieve();
    // TODO: Handle 'response' of type ApiV2MetaResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV2MetaResponse](Models/ApiV2MetaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

