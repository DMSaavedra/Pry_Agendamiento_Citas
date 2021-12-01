<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agendar.aspx.cs" Inherits="Pry_Agendamiento_Citas.Agendar" %>

<link href="https://cdn01.jotfor.ms/static/formCss.css?3.3.29373" rel="stylesheet" type="text/css" />
<link type="text/css" rel="stylesheet" href="https://cdn02.jotfor.ms/css/styles/nova.css?3.3.29373" />
<style type="text/css">@media print{.form-section{display:inline!important}.form-pagebreak{display:none!important}.form-section-closed{height:auto!important}.page-section{position:initial!important}}</style>
<link type="text/css" rel="stylesheet" href="https://cdn03.jotfor.ms/themes/CSS/566a91c2977cdfcd478b4567.css?"/>
<link type="text/css" rel="stylesheet" href="https://cdn01.jotfor.ms/css/styles/payment/payment_feature.css?3.3.29373" />
<style type="text/css">
    .form-label-left{
        width:150px;
    }
    .form-line{
        padding-top:12px;
        padding-bottom:12px;
    }
    .form-label-right{
        width:150px;
    }
    .form-all{
        width:690px;
        color:#555 !important;
        font-family:"Lucida Grande", "Lucida Sans Unicode", "Lucida Sans", Verdana, sans-serif;
        font-size:14px;

    }
</style>
<center>
<form class="jotform-form"  method="post" enctype="multipart/form-data" name="form_213329052517653" id="213329052517653" accept-charset="utf-8" autocomplete="on">
  <input type="hidden" name="formID" value="213329052517653" />
  <input type="hidden" id="JWTContainer" value="" />
  <input type="hidden" id="cardinalOrderNumber" value="" />
  <div role="main" class="form-all">
    <ul class="form-section page-section">
      <li id="cid_1" class="form-input-wide" data-type="control_head">
        <div style="display:table;width:100%">
          <div class="form-header-group hasImage header-default" data-imagealign="Left">
            
            <div class="header-text httal htvam">
              <h2 id="header_1" class="form-header" data-component="header">
                  Agendamiento de citas medicas              </h2>
              <div id="subHeader_1" class="form-subHeader">
                Centro medico
              </div>
            </div>
          </div>
        </div>
      </li>
      <li id="cid_22" class="form-input-wide" data-type="control_head">
        <div class="form-header-group  header-default">
          <div class="header-text httal htvam">
            <h2 id="header_22" class="form-header" data-component="header">
              Datos del Paciente
            </h2>
          </div>
        </div>
      </li>
      <li class="form-line jf-required" data-type="control_fullname" id="id_15">
        <label class="form-label form-label-left form-label-auto" id="label_15" for="prefix_15">
          Nombres y Apellidos del Paciente
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_15" class="form-input jf-required">
          <div data-wrapper-react="true" class="extended">
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="prefix">
              <select data-component="prefix" name="q15_nombresY[prefix]" id="prefix_15" class="dropdown-match-height form-dropdown validate[required]" aria-labelledby="label_15 sublabel_15_prefix" autoComplete="section-input_15 honorific-prefix">
                <option value="Sr"> Sr </option>
                <option value="Sra Srta"> Sra </option>
              </select>
              <label class="form-sub-label" for="prefix_15" id="sublabel_15_prefix" style="min-height:13px" aria-hidden="false"> Prefijo </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="first">
              <input type="text" id="first_15" name="q15_nombresY[first]" class="form-textbox validate[required]" data-defaultvalue="" autoComplete="section-input_15 given-name" size="10" value="" data-component="first" aria-labelledby="label_15 sublabel_15_first" required="" />
              <label class="form-sub-label" for="first_15" id="sublabel_15_first" style="min-height:13px" aria-hidden="false"> Nombre </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="middle">
              <input type="text" id="middle_15" name="q15_nombresY[middle]" class="form-textbox" data-defaultvalue="" autoComplete="section-input_15 additional-name" size="10" value="" data-component="middle" aria-labelledby="label_15 sublabel_15_middle" required="" />
              <label class="form-sub-label" for="middle_15" id="sublabel_15_middle" style="min-height:13px" aria-hidden="false"> Segundo Nombre </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="last">
              <input type="text" id="last_15" name="q15_nombresY[last]" class="form-textbox validate[required]" data-defaultvalue="" autoComplete="section-input_15 family-name" size="15" value="" data-component="last" aria-labelledby="label_15 sublabel_15_last" required="" />
              <label class="form-sub-label" for="last_15" id="sublabel_15_last" style="min-height:13px" aria-hidden="false"> Apellido </label>
            </span>
          </div>
        </div>
      </li>
      <li class="form-line jf-required" data-type="control_email" id="id_26">
        <label class="form-label form-label-left form-label-auto" id="label_26" for="input_26">
          Correo Electronico
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_26" class="form-input jf-required">
          <span class="form-sub-label-container" style="vertical-align:top">
            <input type="email" id="input_26" name="q26_correoElectronico" class="form-textbox validate[required, Email]" data-defaultvalue="" size="30" value="" placeholder=" " data-component="email" aria-labelledby="label_26 sublabel_input_26" required="" />
            <label class="form-sub-label" for="input_26" id="sublabel_input_26" style="min-height:13px" aria-hidden="false"> medico@medico.com </label>
          </span>
        </div>
      </li>
      <li class="form-line" data-type="control_fullname" id="id_16">
        <label class="form-label form-label-left form-label-auto" id="label_16" for="first_16"> Nombre del Acompanante </label>
        <div id="cid_16" class="form-input">
          <div data-wrapper-react="true">
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="first">
              <input type="text" id="first_16" name="q16_nombreDel[first]" class="form-textbox" data-defaultvalue="" autoComplete="section-input_16 given-name" size="10" value="" data-component="first" aria-labelledby="label_16 sublabel_16_first" />
              <label class="form-sub-label" for="first_16" id="sublabel_16_first" style="min-height:13px" aria-hidden="false"> Nombre </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="last">
              <input type="text" id="last_16" name="q16_nombreDel[last]" class="form-textbox" data-defaultvalue="" autoComplete="section-input_16 family-name" size="15" value="" data-component="last" aria-labelledby="label_16 sublabel_16_last" />
              <label class="form-sub-label" for="last_16" id="sublabel_16_last" style="min-height:13px" aria-hidden="false"> Apellido </label>
            </span>
          </div>
        </div>
      </li>
      <li class="form-line jf-required" data-type="control_address" id="id_17">
        <label class="form-label form-label-left form-label-auto" id="label_17" for="input_17_addr_line1">
          Direccion
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_17" class="form-input jf-required">
          <div summary="" class="form-address-table jsTest-addressField">
            <div class="form-address-line-wrapper jsTest-address-line-wrapperField">
              <span class="form-address-line form-address-street-line jsTest-address-lineField">
                <span class="form-sub-label-container" style="vertical-align:top">
                  <input type="text" id="input_17_addr_line1" name="q17_direccion[addr_line1]" class="form-textbox validate[required] form-address-line" data-defaultvalue="" autoComplete="section-input_17 address-line1" value="" data-component="address_line_1" aria-labelledby="label_17 sublabel_17_addr_line1" />
                  <label class="form-sub-label" for="input_17_addr_line1" id="sublabel_17_addr_line1" style="min-height:13px" aria-hidden="false"> Direccion de la calle </label>
                </span>
              </span>
            </div>
            
            <div class="form-address-line-wrapper jsTest-address-line-wrapperField">
              <span class="form-address-line form-address-city-line jsTest-address-lineField ">
                <span class="form-sub-label-container" style="vertical-align:top">
                  <input type="text" id="input_17_city" name="q17_direccion[city]" class="form-textbox validate[required] form-address-city" data-defaultvalue="" autoComplete="section-input_17 address-level2" value="" data-component="city" aria-labelledby="label_17 sublabel_17_city" />
                  <label class="form-sub-label" for="input_17_city" id="sublabel_17_city" style="min-height:13px" aria-hidden="false"> Ciudad </label>
                </span>
              </span>
              <span class="form-address-line form-address-state-line jsTest-address-lineField ">
                <span class="form-sub-label-container" style="vertical-align:top">
                  <input type="text" id="input_17_state" name="q17_direccion[state]" class="form-textbox validate[required] form-address-state" data-defaultvalue="" autoComplete="section-input_17 address-level1" value="" data-component="state" aria-labelledby="label_17 sublabel_17_state" />
                  <label class="form-sub-label" for="input_17_state" id="sublabel_17_state" style="min-height:13px" aria-hidden="false"> Estado / Provincia </label>
                </span>
              </span>
            </div>
            
          </div>
        </div>
      </li>
      <li class="form-line jf-required" data-type="control_phone" id="id_18">
        <label class="form-label form-label-left form-label-auto" id="label_18" for="input_18_area">
          Numero de telefono fijo
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_18" class="form-input jf-required">
          <div data-wrapper-react="true">
            
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="phone">
              <input type="tel" id="input_18_phone" name="q18_numeroDe[phone]" class="form-textbox validate[required]" data-defaultvalue="" autoComplete="section-input_18 tel-local" value="" data-component="phone" aria-labelledby="label_18 sublabel_18_phone" required="" />
              <label class="form-sub-label" for="input_18_phone" id="sublabel_18_phone" style="min-height:13px" aria-hidden="false"> Numero de telefono </label>
            </span>
          </div>
        </div>
      </li>
      <li class="form-line" data-type="control_phone" id="id_19">
        <label class="form-label form-label-left form-label-auto" id="label_19" for="input_19_area"> Numero de celular </label>
        <div id="cid_19" class="form-input">
          <div data-wrapper-react="true">
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="areaCode">
              <input type="tel" id="input_19_area" name="q19_numeroDe19[area]" class="form-textbox" data-defaultvalue="" autoComplete="section-input_19 tel-area-code" value="" data-component="areaCode" aria-labelledby="label_19 sublabel_19_area" />
              <span class="phone-separate" aria-hidden="true">
                 -
              </span>
              <label class="form-sub-label" for="input_19_area" id="sublabel_19_area" style="min-height:13px" aria-hidden="false"> Codigo de area </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top" data-input-type="phone">
              <input type="tel" id="input_19_phone" name="q19_numeroDe19[phone]" class="form-textbox" data-defaultvalue="" autoComplete="section-input_19 tel-local" value="" data-component="phone" aria-labelledby="label_19 sublabel_19_phone" />
              <label class="form-sub-label" for="input_19_phone" id="sublabel_19_phone" style="min-height:13px" aria-hidden="false"> Numero de telefono </label>
            </span>
          </div>
        </div>
      </li>
      <li class="form-line jf-required" data-type="control_dropdown" id="id_28">
        <label class="form-label form-label-left form-label-auto" id="label_28" for="input_28">
          Seleccione si ya es Paciente
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_28" class="form-input jf-required">
          <select class="form-dropdown validate[required]" id="input_28" name="q28_seleccioneSi" style="width:150px" data-component="dropdown" required="">
            <option value="">  </option>
            <option value="Primera Vez"> Primera Vez </option>
            <option value="Ya Soy Paciente "> Ya Soy Paciente </option>
          </select>
        </div>
      </li>
      <li class="form-line jf-required form-field-hidden" style="display:none;" data-type="control_dropdown" id="id_32">
        <label class="form-label form-label-left form-label-auto" id="label_32" for="input_32">
          Tipo de Consulta
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_32" class="form-input jf-required">
          <select class="form-dropdown validate[required]" id="input_32" name="q32_tipoDe" style="width:150px" data-component="dropdown" required="">
            <option value="">  </option>
            <option value="Lectura de Exámenes"> Lectura de Exámenes </option>
            <option value="Control"> Control </option>
            <option value="Eventual"> Eventual </option>
            <option value="Primera Vez"> Primera Vez </option>
          </select>
        </div>
      </li>
      <li class="form-line form-field-hidden" style="display:none;" data-type="control_textarea" id="id_33">
        <label class="form-label form-label-left form-label-auto" id="label_33" for="input_33"> Describa sus Síntomas, Breve-mente </label>
        <div id="cid_33" class="form-input">
          <textarea id="input_33" class="form-textarea" name="q33_describaSus" cols="40" rows="6" data-component="textarea" aria-labelledby="label_33"></textarea>
        </div>
      </li>

      <li class="form-line jf-required allowTime" data-type="control_datetime" id="id_27">
        <label class="form-label form-label-left form-label-auto" id="label_27" for="day_27">
          Fecha
          <span class="form-required">
            *
          </span>
        </label>
        <div id="cid_27" class="form-input jf-required">
          <div data-wrapper-react="true" class="extended notLiteMode">
            <span class="form-sub-label-container" style="vertical-align:top">
              <input type="tel" class="currentDate form-textbox validate[required, disallowPast, limitDate]" id="day_27" name="q27_fecha[day]" size="2" data-maxlength="2" data-age="" maxLength="2" value="29" required="" autoComplete="section-input_27 off" aria-labelledby="label_27 sublabel_27_day" />
              <span class="date-separate" aria-hidden="true">
                 /
              </span>
              <label class="form-sub-label" for="day_27" id="sublabel_27_day" style="min-height:13px" aria-hidden="false"> Dia </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top">
              <input type="tel" class="form-textbox validate[required, disallowPast, limitDate]" id="month_27" name="q27_fecha[month]" size="2" data-maxlength="2" data-age="" maxLength="2" value="11" required="" autoComplete="section-input_27 off" aria-labelledby="label_27 sublabel_27_month" />
              <span class="date-separate" aria-hidden="true">
                 /
              </span>
              <label class="form-sub-label" for="month_27" id="sublabel_27_month" style="min-height:13px" aria-hidden="false"> Mes </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top">
              <input type="tel" class="form-textbox validate[required, disallowPast, limitDate]" id="year_27" name="q27_fecha[year]" size="4" data-maxlength="4" data-age="" maxLength="4" value="2021" required="" autoComplete="section-input_27 off" aria-labelledby="label_27 sublabel_27_year" />
              <label class="form-sub-label" for="year_27" id="sublabel_27_year" style="min-height:13px" aria-hidden="false"> Year </label>
            </span>
            <span class="form-sub-label-container" style="vertical-align:top">
              <img class="showAutoCalendar newDefaultTheme-dateIcon icon-seperatedMode" alt="Pick a Date" id="input_27_pick" src="https://cdn.jotfor.ms/images/calendar.png" data-component="datetime" aria-hidden="true" data-allow-time="Yes" data-version="v1" />
              <label class="form-sub-label" for="input_27_pick" style="border:0;clip:rect(0 0 0 0);height:1px;margin:-1px;overflow:hidden;padding:0;position:absolute;width:1px;white-space:nowrap" aria-hidden="true"> Date Picker Icon </label>
            </span>
            <span class="allowTime-container">
              <span class="form-sub-label-container" style="vertical-align:top">
                <select class="currentTime time-dropdown form-dropdown validate[required, disallowPast, limitDate]" id="hour_27" name="q27_fecha[hour]" aria-labelledby="label_27 sublabel_27_hour">
                  <option>  </option>
                  <option value="1"> 1 </option>
                  <option value="2"> 2 </option>
                  <option value="3"> 3 </option>
                  <option value="4"> 4 </option>
                  <option value="5"> 5 </option>
                  <option value="6"> 6 </option>
                  <option value="7"> 7 </option>
                  <option value="8"> 8 </option>
                  <option value="9"> 9 </option>
                  <option value="10"> 10 </option>
                  <option selected="" value="11"> 11 </option>
                  <option value="12"> 12 </option>
                </select>
                <span class="date-separate" aria-hidden="true">
                   :
                </span>
                <label class="form-sub-label" for="hour_27" id="sublabel_27_hour" style="min-height:13px" aria-hidden="false"> Hora </label>
              </span>
              <span class="form-sub-label-container" style="vertical-align:top">
                <select class="time-dropdown form-dropdown validate[required, disallowPast, limitDate]" id="min_27" name="q27_fecha[min]" aria-labelledby="label_27 sublabel_27_minutes">
                  <option>  </option>
                  <option selected="" value="00"> 00 </option>
                  <option value="30"> 30 </option>
                </select>
                <label class="form-sub-label" for="min_27" id="sublabel_27_minutes" style="min-height:13px" aria-hidden="false"> Minutos </label>
              </span>
              <span class="form-sub-label-container" style="vertical-align:top">
                <select class="time-dropdown form-dropdown validate[required, disallowPast, limitDate]" id="ampm_27" name="q27_fecha[ampm]" aria-labelledby="label_27 sublabel_27_ampm">
                  <option value="AM"> AM </option>
                  <option selected="" value="PM"> PM </option>
                </select>
                <label class="form-sub-label" for="ampm_27" id="sublabel_27_ampm" style="border:0;clip:rect(0 0 0 0);height:1px;margin:-1px;overflow:hidden;padding:0;position:absolute;width:1px;white-space:nowrap" aria-hidden="false"> AM/PM Option </label>
              </span>
            </span>
          </div>
        </div>
      </li>
      
      <li class="form-line" data-type="control_payment" id="id_13" data-payment="true">
        <label class="form-label form-label-left form-label-auto" id="label_13" for="input_13"> Honorarios de Consulta </label>
        <div id="cid_13" class="form-input">
          <div data-wrapper-react="true" class="product-container-wrapper">
            <div class="filter-container">
            </div>
            <input type="hidden" name="simple_fpc" data-payment_type="payment" data-component="payment1" value="13" />
            <input type="hidden" name="payment_total_checksum" id="payment_total_checksum" data-component="payment2" />
            <div id="image-overlay" class="overlay-content" style="display:none">
              <img id="current-image" />
              <span class="lb-prev-button">
                prev
              </span>
              <span class="lb-next-button">
                next
              </span>
              <span class="lb-close-button">
                ( X )
              </span>
              <span class="image-overlay-product-container">
                <ul class="form-overlay-item" pid="1000" hasicon="true" hasimages="false" iconvalue="https://jotform.com/images/security_certificate_seal_comodo.png">
                </ul>
              </span>
            </div>
            <div data-wrapper-react="true">
              <span class="form-product-item hover-product-item " categories="non-categorized" pid="1000">
                <div data-wrapper-react="true" class="form-product-item-detail">
                  <input type="checkbox" class="form-checkbox  form-product-input" id="input_13_1000" name="q13_honorariosDe[][id]" value="1000" checked="" disabled="" />
                  <label for="input_13_1000" class="form-product-container">
                    <span data-wrapper-react="true">
                      <span class="form-product-name" id="product-name-input_13_1000">
                        Consulta
                      </span>
                      <span class="form-product-details">
                        <b>
                          <span data-wrapper-react="true">
                            <span id="input_13_1000_price">
                              10$
                            </span>
                          </span>
                        </b>
                      </span>
                    </span>
                  </label>
                  <br/>
                  <br/>
                  <span class="form-sub-label-container" style="vertical-align:top">
                    <label class="form-sub-label" for="input_13_quantity_1000_0" style="min-height:13px" aria-hidden="false"> Calidad </label>
                    <select class="form-dropdown" name="q13_honorariosDe[special_1000][item_0]" id="input_13_quantity_1000_0">
                      <option value="1"> 1 </option>
                    </select>
                  </span>
                </div>
              </span>
              <br/>
              <span class="form-payment-divider" style="margin:0 0 8px">
              </span>
              <span class="form-payment-subtotal form-payment-label">
                <span id="subtotal-text">
                  Subtotal
                </span>
                 
                <span class="form-payment-price">
                  <span data-wrapper-react="true">
                    <span id="payment_subtotal">
                      0,00
                    </span>
                    <span class="currency_abr">
                      $
                    </span>
                  </span>
                </span>
              </span>
              <span class="form-payment-tax form-payment-label">
                <span id="tax-text">
                  IVA
                </span>
                 
                <span class="form-payment-price">
                  <span data-wrapper-react="true">
                    <span id="payment_tax">
                      0,00
                    </span>
                    <span class="currency_abr">
                      $
                    </span>
                  </span>
                </span>
              </span>
              <span class="form-payment-total">
                <b>
                  <span id="total-text">
                    Total
                  </span>
                  <span class="form-payment-price">
                    <span data-wrapper-react="true">
                      <span id="payment_total">
                        0,00
                      </span>
                      <span class="currency_abr">
                        $
                      </span>
                    </span>
                  </span>
                </b>
              </span>
            </div>
            <button id="input_2" type="submit" class="form-submit-button submit-button jf-form-buttons jsTest-submitField" data-component="button" data-content="">
              Enviar
            </button>
          </div>
        </div>
      </li>
      <li style="display:none">
        Should be Empty:
        <input type="text" name="website" value="" />
      </li>
    </ul>
  </div>
  
</center>
  </div>
</form>
</html>
