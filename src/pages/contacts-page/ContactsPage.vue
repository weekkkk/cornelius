<script lang="ts" setup>
import { GridBlock, ImageBlock } from '@/shared'
</script>

<template>
  <GridBlock is-mobile-hide class="jc-fs" :l="2" :r="5" :t="3" b="end">
    <table class="accreditations_page-contacts_table">
      <tr>
        <th>Почта</th>
        <td>
          <p>cornelius@gmail.com</p>
        </td>
      </tr>
      <tr>
        <th>Центральный офис (тел/факс)</th>
        <td>
          <p>+373 533 83481 (9:00-17:00)</p>
          <p>+373 777 83485 (9:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Производственно-техническая база</th>
        <td>
          <p>+373 533 24599 (8:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>ПТО, Маркетинг (Viber/WhatsApp)</th>
        <td>
          <p>+373 795 35511</p>
          <p>+373 777 66761 (10:00-18:00)</p>
        </td>
      </tr>
      <tr>
        <th>Директор (Viber)</th>
        <td>
          <p>+373 777 13084 (8:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Проектный отдел</th>
        <td>
          <p>+373 778 95589 (9:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Бухгалтерия</th>
        <td>
          <p>+373 533 53721 (9:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Центральный офис</th>
        <td>
          <p>Молдова, г.Тирасполь, ул. Карла-Либкнехта 385</p>
        </td>
      </tr>
      <tr>
        <th>Производственно-техническая база</th>
        <td>
          <p>с. Суклея, ул. Котовского 81</p>
        </td>
      </tr>
    </table>
  </GridBlock>

  <GridBlock is-mobile-hide class="jc-c" :l="2" :r="5" :t="2" :b="4">
    <h1>Контакты</h1>
  </GridBlock>

  <GridBlock is-mobile-hide class="jc-c bg-second-50" :l="6" :r="9" :t="3" :b="6"> </GridBlock>
  <GridBlock is-mobile-hide class="jc-c bg-second-25" :l="6" :r="8" :t="6" :b="9"> </GridBlock>
  <GridBlock is-mobile-hide class="jc-c bg-second-75" :l="8" :r="9" :t="6" :b="9"> </GridBlock>

  <GridBlock is-mobile-show class="jc-c" :l="2" r="end" :t="3" :b="8">
    <h2>Контакты</h2>

    <table class="accreditations_page-contacts_table" style="margin-right: var(--corn-page-px)">
      <tr>
        <th>Почта</th>
        <td>
          <p>cornelius@gmail.com</p>
        </td>
      </tr>
      <tr>
        <th>Центральный офис (тел/факс)</th>
        <td>
          <p>+373 533 83481 (9:00-17:00)</p>
          <p>+373 777 83485 (9:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Производственно-техническая база</th>
        <td>
          <p>+373 533 24599 (8:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>ПТО, Маркетинг (Viber/WhatsApp)</th>
        <td>
          <p>+373 795 35511</p>
          <p>+373 777 66761 (10:00-18:00)</p>
        </td>
      </tr>
      <tr>
        <th>Директор (Viber)</th>
        <td>
          <p>+373 777 13084 (8:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Проектный отдел</th>
        <td>
          <p>+373 778 95589 (9:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Бухгалтерия</th>
        <td>
          <p>+373 533 53721 (9:00-17:00)</p>
        </td>
      </tr>
      <tr>
        <th>Центральный офис</th>
        <td>
          <p>Молдова, г.Тирасполь, ул. Карла-Либкнехта 385</p>
        </td>
      </tr>
      <tr>
        <th>Производственно-техническая база</th>
        <td>
          <p>с. Суклея, ул. Котовского 81</p>
        </td>
      </tr>
    </table>
  </GridBlock>
</template>

<style lang="scss" scoped>
.accreditations_page {
  &-contacts_table {
    border-collapse: collapse;
    td,
    th {
      // height: 5rem;
      padding: 0.5rem 0.5rem;
      text-align: left;
      font-size: var(--n-fs-p);
      font-weight: var(--n-fw-regular);

      &:last-child {
        text-align: right;
      }
    }
    tr {
      &:nth-child(2n + 1) {
        background-color: var(--n-second-0);
      }
    }
  }
}
</style>
