<script lang="ts" setup>
import { TitleBlock } from '@/shared'
import { ContactForm, SocialLinks } from '@/widgets'


//Тут логика для 14 пункта 

/**
 * Проверяем, использует ли пользователь операционную систему Windows
 */
const isWindows = window.navigator.userAgent.includes('Windows');

/**
 * Проверяем, использует ли пользователь операционную систему Android
 */
const isAndroid = window.navigator.userAgent.includes('Android');

const openPhoneApp = (phoneNumber: string) => {
  if (isWindows) {
    /**
     * Открываем приложение для Windows
     */
    window.location.href = `tel:${phoneNumber}`;
  } else if (isAndroid) {
    /**
     * Показываем приглашение для Android
     */
    if (confirm('Выберите способ совершения звонка:')) {
      window.location.href = `tel:${phoneNumber}`;
    } else {
     /**
      * Тут надо попробовать чат в Viber 
      */
    }
  } else {
    /**
     * Для других платформ для телефона
     */
    window.location.href = `tel:${phoneNumber}`;
  }
};
</script>



<template>
  <!-- style="transform: none" -->
  <TitleBlock
    :x-start="2"
    :x-end="5"
    :y-start="1"
    :y-end="3"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="2"
    :mobile-y-end="3"
  >
    Контакты
  </TitleBlock>
  <div class="contacts_page-contacts_table f fd-col">
    <table>
      <tr>
        <td>Почта</td>
        <td>corneliusgas@gmail.com</td>
      </tr>
      <tr>
        <td>Центральный офис (тел/факс)</td>
        <td>
          <a href="tel:+373 533 83481"  class="contackt_href"><p>+373 533 83481 (9:00-17:00)</p></a>
          <a href="tel:+373  777 83485"  class="contackt_href"> <p>+373 777 83485 (9:00-17:00)</p></a>
        </td>
      </tr>
      <tr>
        <td>Производственно-техническая база с. Суклея</td>
       <td> <a href="tel:+373 533 24599"  class="contackt_href">+373 533 24599  (8:00-17:00)</a></td>
      </tr>
      <tr>
        <td>ПТО, Маркетинг (Viber/WhatsApp)</td>
        <a href="#" class="contackt_href" @click="openPhoneApp('+37379535511')"> <td>+373 795 35511</td></a>
        <a href="#" class="contackt_href" @click="openPhoneApp('+37377766761')">  <td>+373 777 66761 (10:00-18:00)</td></a>
      </tr>
      <tr>
        <td>Директор (Viber)</td>
        <a href="#" class="contackt_href" @click="openPhoneApp('+37377713084')"> <td>+373 777 13084 (8:00-17:00)</td></a>
      </tr>
      <tr>
        <td>Проектный отдел</td>
        <a href="tel:+373 778 95589" class="contackt_href"><td>+373 778 95589 (9:00-17:00)</td></a>
      </tr>
      <tr>
        <td>Бухгалтерия</td>
        <a href="tel:+373 533 53721" class="contackt_href"><td>+373 533 53721 (9:00-17:00)</td></a>
      </tr>
    </table>
    <div class="f contacts_page-contacts_table-social_links">
      <SocialLinks />
    </div>
  </div>

  <!-- style="transform: none" -->
  <!-- <TitleBlock
    :x-start="6"
    x-end="end"
    :y-start="1"
    :y-end="3"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="4"
    :mobile-y-end="5"
  >
    Адреса
  </TitleBlock> -->

  <table class="contacts_page-addresses_table">
    <tr>
      <td>Центральный офис</td>
      <td>Молдова, г.Тирасполь, ул. Карла-Либкнехта 385</td>
      <!-- каб. 201, 202, 204 -->
    </tr>
    <tr>
      <td>Производственно-техническая база</td>
      <td>с. Суклея, ул. Котовского 81</td>
    </tr>
  </table>

  <div class="contacts_page-contact_form-wrap f ai-fe">
    <ContactForm class="w-100" />
  </div>
</template>

<style lang="scss" scoped>
.contacts_page {
  &-contact_form {
    &-wrap {
      grid-column-start: 6;
      grid-column-end: end;
      grid-row-start: 4;
      grid-row-end: end;
      padding-bottom: var(--page-px);
      padding-right: var(--page-px);
      @media (max-width: 800px) {
        grid-row-start: 6;
        grid-row-end: end;
        grid-column-start: 2;
        grid-column-end: end;
      }
    }
  }
  &-contacts_table {
    grid-column-start: 2;
    grid-column-end: 5;
    grid-row-start: 3;
    grid-row-end: 7;
    font-size: 16px;

    vertical-align: top;
    @media (max-width: 800px) {
      grid-row-start: 3;
      grid-row-end: 4;
      grid-column-start: 2;
      grid-column-end: 5;
      font-size: 8px;
      --n-fs-p: 8px !important;
      td {
        padding: 8px 0 !important;
      }
      &-social_links {
        display: none;
      }
    }
  }
  &-addresses_table {
    grid-column-start: 6;
    grid-column-end: 9;
    grid-row-start: 3;
    grid-row-end: 4;
    font-size: 16px;
    vertical-align: top;
    @media (max-width: 800px) {
      grid-row-start: 5;
      grid-row-end: 6;
      grid-column-start: 2;
      grid-column-end: 5;
      font-size: 8px;
      --n-fs-p: 8px !important;
      td {
        padding: 8px 0 !important;
      }
    }
  }
  &-contacts_table,
  &-addresses_table {
    td {
      padding: 16px 0px;
      &:first-child {
        color: var(--n-second-75);
        width: 50%;
      }
      &:last-child {
        font-weight: 500;
        text-align: right;
        // white-space: nowrap;
      }
    }
  }
}

.contackt_href{
  color: #000;
  text-decoration: none;
  border-bottom: none;
}
a{
  border-bottom: none;
}
</style>

<style lang="scss">
a{
  border-bottom: none;
}
#contacts.page_li {
  .title_block {
    @media (max-width: 800px) {
      transform: none !important;
    }
  }
  .page_li-content {
    @media (max-width: 800px) {
      grid-template-rows:
        calc(var(--page-px) + 40px) 54px fit-content(100px) 54px fit-content(100px) fit-content(
          100px
        )
        var(--page-px);
    }
  }
}
</style>
