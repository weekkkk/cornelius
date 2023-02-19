<script lang="ts" setup></script>

<template>
  <section class="f jc-c p-4">
    <div class="container f g-4 py-4 design_columns">
      <div class="f fd-col rg-3 w-100">
        <h1>Проектирование строительных объектов</h1>
        <div class="f fd-col ta-j rg-2">
          <p>
            ООО "Корнелиус" поставляет промышленное оборудование в сфере
            газификации и систем теплоснабжения.
          </p>
          <p>
            Счётчики, электронные корректоры объёма газа, горелки, котлы, насосы
            по выгодным (лучшим) ценам с доставкой по Приднестровью, Молдове и
            Украине.
          </p>
        </div>
      </div>

      <div class="document_list f fd-col w-100 rg-2">
        <p class="bg-second-0 fw-bold px-3 py-2 c-second-75">
          Разрешительные документы
        </p>
        <ul class="f fd-col ai-fs fw-medium fs-small-p">
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0470-15.pdf"
            >
              Аккредитация 0470-15
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0488-15.pdf"
            >
              Аккредитация 0488-15
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0533-16.pdf"
            >
              Аккредитация 0533-16
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0687-19.pdf"
            >
              Аккредитация 0687-19
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/license.pdf"
            >
              Лицензия ООО Корнелиус
            </a>
          </li>
        </ul>
      </div>
    </div>
  </section>
</template>

<style lang="scss" scoped>
.design_columns {
  @media (max-width: 624px) {
    flex-direction: column;
  }
  .document_list {
    flex-grow: 1;
    a:hover {
      color: var(--n-brand);
    }
  }
}
</style>
