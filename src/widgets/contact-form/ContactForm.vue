<script lang="ts" setup></script>

<template>
  <div class="contact_form f fd-col ai-fs rg-4">
    <div class="f fd-col rg-3 w-100">
      <input type="text" placeholder="Введите ваше имя" />
      <input type="text" placeholder="Введите вашу почту" />
      <input type="text" placeholder="Введите ваше сообщение" />
    </div>

    <button class="px-5">Отправить</button>
  </div>
</template>

<style lang="scss" scoped>
.contact_form {
  input {
    outline: none;
    border: none;
    border-bottom: 1px solid var(--n-second-50);
    font-family: inherit;
    font-size: inherit;
    padding: 12px 8px;
  }
    > button {
      width: calc(100% / 3);
    }
  @media (max-width: 800px) {
    font-size: 12px;
    row-gap: 16px;
    > div {
    row-gap: 8px;
    }
    > button {
      padding-top: 8px;
      padding-bottom: 8px;
      width: 100%;
    }
  }
}
</style>
